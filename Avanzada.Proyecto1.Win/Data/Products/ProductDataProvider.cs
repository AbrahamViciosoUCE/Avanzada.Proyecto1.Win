using Avanzada.Proyecto1.Win.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using System.Reflection.Metadata;


namespace Avanzada.Proyecto1.Win.Data.Products
{
    public class ProductDataProvider : IProductDataProvider
    {
        IConfiguration _configuration;

        public ProductDataProvider(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<Product> GetProducts()
        {
            IEnumerable<Product> products = new List<Product>();
            string queryString = @"SELECT A.*, B.CompanyName SupplierName, 
                                            C.CategoryName FROM Products A 
            INNER JOIN dbo.Suppliers B ON A.SupplierID = B.SupplierID 
            INNER JOIN Categories C ON C.CategoryID = A.CategoryID;";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                products = connection.Query<Product>(queryString);

                return products;
            }
        }

        public IEnumerable<int> CreateProduct(Product product)
        {
            string query = @"INSERT INTO [dbo].[Products]
                   ([ProductName]
                   ,[SupplierID]
                   ,[CategoryID]
                   ,[QuantityPerUnit]
                   ,[UnitPrice]
                   ,[UnitsInStock]
                   ,[UnitsOnOrder]
                   ,[ReorderLevel]
                   ,[Discontinued])
             OUTPUT INSERTED.ProductID
             VALUES
                   (@ProductName
                   ,@SupplierID
                   ,@CategoryID
                   ,@QuantityPerUnit
                   ,@UnitPrice
                   ,@UnitsInStock
                   ,@UnitsOnOrder
                   ,@ReorderLevel
                   ,@Discontinued)";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<int>(query, product);
            }
        }

        public IEnumerable<Product> UpdateProduct(Product product)
        {
            string query =
            @"UPDATE [dbo].[Products]
               SET [ProductName] = @ProductName
                  ,[SupplierID] = @SupplierID
                  ,[CategoryID] = @CategoryID
                  ,[QuantityPerUnit] = @QuantityPerUnit
                  ,[UnitPrice] = @UnitPrice
                  ,[UnitsInStock] = @UnitsInStock
                  ,[UnitsOnOrder] = @UnitsOnOrder
                  ,[ReorderLevel] = @ReorderLevel
                  ,[Discontinued] = @Discontinued
             WHERE ProductID = @ProductID";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Product>(query, product);
            }
        }

        public IEnumerable<Product> GetProductByID(int id)
        {
            IEnumerable<Product> products = new List<Product>();
            string queryString = $@"SELECT A.*, B.CompanyName SupplierName, C.CategoryName FROM Products A 
            INNER JOIN dbo.Suppliers B ON A.SupplierID = B.SupplierID 
            INNER JOIN Categories C ON C.CategoryID = A.CategoryID
			WHERE A.ProductID = ${id};";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Product>(queryString);
            }
        }

        public IEnumerable<Product> DeleteProduct(int id)
        {
            string queryString = @"DELETE FROM Products WHERE ProductID = @ProductID";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Product>(queryString, new Product()
                {
                    ProductID = id
                });
            }
        }
    }
}
