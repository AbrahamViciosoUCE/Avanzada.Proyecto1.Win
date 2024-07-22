using Avanzada.Proyecto1.Win.Data;
using Avanzada.Proyecto1.Win.Data.Categories;
using Avanzada.Proyecto1.Win.Data.Customer;
using Avanzada.Proyecto1.Win.Data.Employee;
using Avanzada.Proyecto1.Win.Data.Order;
using Avanzada.Proyecto1.Win.Data.OrderDetails;
using Avanzada.Proyecto1.Win.Data.Products;
using Avanzada.Proyecto1.Win.Data.Suppliers;
using Avanzada.Proyecto1.Win.Views;
using Avanzada.Proyecto1.Win.Views.Controls;
using Avanzada.Proyecto1.Win.Views.Modals;
using FluentValidation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Avanzada.Proyecto1.Win
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug().WriteTo.File("logs.log").CreateLogger(); 
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
            
            ServiceCollection collectionServices = new ServiceCollection();

            collectionServices.AddLogging(builder =>
                {
                    builder.ClearProviders();
                    builder.AddSerilog();
                }
            );
           
            collectionServices.AddSingleton<IConfiguration>(configuration);

            collectionServices.AddScoped<FormProduct>();
            collectionServices.AddScoped<FormCategory>();
            collectionServices.AddScoped<FormSupplier>();
            collectionServices.AddScoped<FormSelectOrder>();

            collectionServices.AddScoped<ProductListControl>();
            collectionServices.AddScoped<CategoriesListControl>();
            collectionServices.AddScoped<SuppliersListControl>();
            collectionServices.AddScoped<FacturationControlCopy>();
            collectionServices.AddScoped<FacturationControl>();

            collectionServices.AddScoped<MainForm>();
            
            collectionServices.AddSingleton<IProductDataProvider, ProductDataProvider>(); 
            collectionServices.AddSingleton<ICategoryDataProvider, CategoryDataProvider>();
            collectionServices.AddSingleton<ISupplierDataProvider, SupplierDataProvider>();
            collectionServices.AddSingleton<ICustomerDataProvider, CustomerDataProvider>();
            collectionServices.AddSingleton<IEmployeeDataProvider, EmployeeDataProvider>();
            collectionServices.AddSingleton<IOrderDataProvider, OrderDataProvider>();
            collectionServices.AddSingleton<IOrderDetailDataProvider, OrderDetailDataProvider>();

            collectionServices.AddSingleton<NorthWindContext>();

            collectionServices.AddValidatorsFromAssemblyContaining<MainForm>(); 

            ServiceProvider serviceProvider = collectionServices.BuildServiceProvider();

            //Global handler
            Application.ThreadException += Application_ThreadException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
            TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskExceptio;

            ApplicationConfiguration.Initialize();
            
            MainForm mainForm = serviceProvider.GetService<MainForm>();

            Application.Run(mainForm);
        }

        private static void TaskScheduler_UnobservedTaskExceptio(object? sender, UnobservedTaskExceptionEventArgs e)
        {
            Log.Error(e.Exception, "Error in TaskScheduler");
            MessageBox.Show(e.Exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            if (e.ExceptionObject is Exception exp)
            {
                Log.Fatal(exp, "Error Fatal");
                MessageBox.Show(exp.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Log.Error("Error domain",e.ExceptionObject);
                MessageBox.Show(e.ExceptionObject.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            Log.Error(e.Exception, "Error in thread");
            MessageBox.Show(e.Exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}