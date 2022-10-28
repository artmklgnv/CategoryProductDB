using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryProductDB.Entities
{
    public class Product : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
        public Product(string name)
        {
            Name = name;
        }
        public void AddCategory(Category category)
        {
            Categories.Add(category);
            category.Products.Add(this);
        }
    }
}
