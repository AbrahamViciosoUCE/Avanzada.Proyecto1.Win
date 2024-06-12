using Avanzada.Proyecto1.Win.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace Avanzada.Proyecto1.Win.Data.Suppliers
{
    public class SupplierDataProvider: ISupplierDataProvider
    {
        public IConfiguration _configuration;

        public SupplierDataProvider(IConfiguration configuration) 
        {
            _configuration = configuration;
        }

        public IEnumerable<int> CreateSupplier(Supplier supplier)
        {
            string query = @"INSERT INTO [dbo].[Suppliers]
                   ([CompanyName]
                   ,[ContactName]
                   ,[ContactTitle]
                   ,[Address]
                   ,[City]
                   ,[Region]
                   ,[PostalCode]
                   ,[Country]
                   ,[Phone]
                   ,[Fax]
                   ,[HomePage])
             OUTPUT INSERTED.SupplierID
             VALUES
                  (@CompanyName
                  ,@ContactName
                  ,@ContactTitle
                  ,@Address
                  ,@City
                  ,@Region
                  ,@PostalCode
                  ,@Country
                  ,@Phone
                  ,@Fax
                  ,@HomePage)";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<int>(query,supplier);
            }
        }

        public IEnumerable<Supplier> DeleteSupplier(int id)
        {
            string queryString = @"DELETE FROM Suppliers WHERE SupplierID = @SupplierID";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Supplier>(queryString, new Supplier()
                {
                    SupplierID = id
                });
            }
        }

        public IEnumerable<Supplier> GetSupplierById(int id)
        {
            string query = $"SELECT * FROM Suppliers WHERE SupplierID = {id};";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Supplier>(query);
            }
        }

        public IEnumerable<Supplier> GetSuppliers()
        {
            string query = "SELECT * FROM Suppliers;";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Supplier>(query);
            }  
        }

        public IEnumerable<Supplier> UpdateSupplier(Supplier supplier)
        {
            string query = @$"UPDATE [dbo].[Suppliers]
               SET [CompanyName] = @CompanyName
                  ,[ContactName] = @ContactName
                  ,[ContactTitle] = @ContactTitle
                  ,[Address] = @Address
                  ,[City] = @City
                  ,[Region] = @Region
                  ,[PostalCode] = @PostalCode
                  ,[Country] = @Country
                  ,[Phone] = @Phone
                  ,[Fax] = @Fax
                  ,[HomePage] = @HomePage
             WHERE SupplierID = @SupplierID";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Supplier>(query, supplier);
            }
        }
    }
}
