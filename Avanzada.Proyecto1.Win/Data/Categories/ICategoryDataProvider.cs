using Avanzada.Proyecto1.Win.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.Categories
{
    public interface ICategoryDataProvider
    {
        IEnumerable<Category> GetCategories();
        IEnumerable<Category> GetCategoryById(int id);
        IEnumerable<int> CreateCategory(Category category);
        IEnumerable<Category> UpdateCategory(Category category);
        IEnumerable<Category> DeleteCategory(int id);
    }
}
