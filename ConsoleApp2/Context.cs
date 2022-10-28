using CategoryProductDB.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategoryProductDB
{
    public class Context : DbContext
    {
        public Context() : base() { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public Context(DbContextOptions<Context> option) : base(option) { }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=.\\DB.db");
        //}
    }
}
