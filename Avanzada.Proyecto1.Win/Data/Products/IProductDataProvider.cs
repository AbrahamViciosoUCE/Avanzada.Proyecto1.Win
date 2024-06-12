using Avanzada.Proyecto1.Win.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avanzada.Proyecto1.Win.Data.Products
{
    public interface IProductDataProvider
    {
        IEnumerable<Product> GetProducts();
        IEnumerable<Product> GetProductByID(int id);
        IEnumerable<Product> DeleteProduct(int id);
        IEnumerable<int> CreateProduct(Product product);
        IEnumerable<Product> UpdateProduct(Product product);
    }
}
