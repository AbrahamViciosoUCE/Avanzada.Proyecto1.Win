using Avanzada.Proyecto1.Win.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.Categories
{
    public class CategoryDataProvider: ICategoryDataProvider
    {
        IConfiguration _configuration;
        public CategoryDataProvider(IConfiguration configuration) { 
            _configuration = configuration;
        }

        public IEnumerable<Category> GetCategories()
        {
            string query = @"SELECT * FROM Categories;";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Category>(query);
            }
        }

        public IEnumerable<int> CreateCategory(Category category)
        {
            string query = @"INSERT INTO [dbo].[Categories]
                   ([CategoryName]
                   ,[Description]
                   ,[Picture])
            OUTPUT INSERTED.CategoryID
             VALUES
                   (@CategoryName
                   ,@Description
                   ,@Picture)";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<int>(query,category);
            }
        }

        public IEnumerable<Category> UpdateCategory(Category category)
        {
            string queryString = @"UPDATE[dbo].[Categories]
               SET[CategoryName] = @CategoryName,
                  [Description] = @Description,
                  [Picture] = @Picture
               WHERE CategoryID = @CategoryID";

            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Category>(queryString, category);
            }
        }

        public IEnumerable<Category> DeleteCategory(int id)
        {
            string queryString = @"DELETE FROM Categories WHERE CategoryID = @CategoryID";

            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Category>(queryString,new Category()
                {
                    CategoryID = id
                });
            }
        }

        public IEnumerable<Category> GetCategoryById(int id)
        {
            string query = @$"SELECT * FROM Categories WHERE CategoryID = {id};";
            using (SqlConnection connection = new SqlConnection(_configuration.GetSection("ConnectionStrings:Database").Value))
            {
                return connection.Query<Category>(query);
            }
        }
    }
}
