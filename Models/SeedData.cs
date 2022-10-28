using BingeShop.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BingeShop.Models
{
    public class SeedData
    {
        private ApplicationDbContext _applicationDbContext;
        public SeedData(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task SeedDatabase()
        {
            await _applicationDbContext.Database.MigrateAsync();
            _applicationDbContext.RemoveRange(_applicationDbContext.Products);
            _applicationDbContext.SaveChanges();
            List<Product> products = new List<Product>()
            {
                new Product(){Name="Macbook",UnitPrice = 5000,Category = "Laptop",Brand = "Apple",Color="White",ProductImage="https://picsum.photos/200/300",Review="",Quatity=10 },
                new Product(){Name="Yoga",UnitPrice = 5000,Category = "Laptop",Brand = "Samsung",Color="Pink",ProductImage="https://picsum.photos/200/300",Review="",Quatity=5 },
                new Product(){Name="Chromebook",UnitPrice = 5000,Category = "Laptop",Brand = "Asus",Color="Green",ProductImage="https://picsum.photos/200/300",Review="",Quatity=5 },
                new Product(){Name="T220 P",UnitPrice = 5000,Category = "Laptop",Brand = "MSI",Color="Red",ProductImage="https://picsum.photos/200/300",Review="",Quatity=4 },
                new Product(){Name="Thinkpad",UnitPrice = 5000,Category = "Laptop",Brand = "Lenovo",Color="Black",ProductImage="https://picsum.photos/200/300",Review="",Quatity=6 },
                new Product(){Name="Z+ flip",UnitPrice = 5000,Category = "Mobile",Brand = "Samsung",Color="Pink",ProductImage="https://picsum.photos/200/300",Review="",Quatity=25 },
                new Product(){Name="Nord",UnitPrice = 500,Category = "Mobile",Brand = "OnePlus",Color="White",ProductImage="https://picsum.photos/200/300",Review="",Quatity=77 },
                new Product(){Name="f9",UnitPrice = 300,Category = "Mobile",Brand = "Oppo",Color="Black",ProductImage="https://picsum.photos/200/300",Review="",Quatity=66 },
                new Product(){Name="iphone 14",UnitPrice = 1100,Category = "Mobile",Brand = "Apple",Color="Red",ProductImage="https://picsum.photos/200/300",Review="",Quatity=1 },
                new Product(){Name="N93",UnitPrice = 200,Category = "Mobile",Brand = "Nokia",Color="Grey",ProductImage="https://picsum.photos/200/300",Review="",Quatity=25 }
            };
            await _applicationDbContext.Products.AddRangeAsync(products);
            await _applicationDbContext.SaveChangesAsync();
        }
    }
}
