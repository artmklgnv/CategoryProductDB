using CategoryProductDB;
using CategoryProductDB.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddDbContext<Context>(options => options.UseSqlite("Data Source=C:\\Users\\ASUS\\Documents\\DB.db"), contextLifetime: ServiceLifetime.Singleton,
    optionsLifetime: ServiceLifetime.Singleton);

        ServiceProvider serviceProvider = services.BuildServiceProvider();
        Context? context = serviceProvider.GetService<Context>();

        if (context != null)
        {
            var devicesCategory = new Category("PC Devices");
            var inputCategory = new Category("Input devices");
            context.Categories.Add(devicesCategory);
            context.Categories.Add(inputCategory);
            context.SaveChanges();

            var mouseG = new Product("mouse G");
            mouseG.AddCategory(devicesCategory);
            mouseG.AddCategory(inputCategory);
            context.Products.Add(mouseG);
            context.SaveChanges();

            var mouseT = new Product("mouse T");
            mouseT.AddCategory(devicesCategory);
            mouseT.AddCategory(inputCategory);
            context.Products.Add(mouseT);
            context.SaveChanges();

            var mouseR = new Product("mouse R");
            mouseR.AddCategory(devicesCategory);
            mouseR.AddCategory(inputCategory);
            context.Products.Add(mouseR);
            context.SaveChanges();

            var keybordS = new Product("keybord S");
            keybordS.AddCategory(devicesCategory);
            keybordS.AddCategory(inputCategory);
            context.Products.Add(keybordS);
            context.SaveChanges();

            var keybordD = new Product("keybord D");
            keybordD.AddCategory(devicesCategory);
            keybordD.AddCategory(inputCategory);
            context.Products.Add(keybordD);
            context.SaveChanges();

            var usbCable = new Product("USB cable");
            context.Products.Add(usbCable);
            context.SaveChanges();
        }
        Console.WriteLine("Hello, World!");
    }
}