using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryProductDB.Entities
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
        public Category(string name)
        {
            Name = name;
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
            product.Categories.Add(this);
        }
    }
}
