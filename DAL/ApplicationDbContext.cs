using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class ApplicationDbContext
    {
        static List<Product> productList = new List<Product>
        {
            new() {ProductId = Guid.NewGuid(), ProductName = "Uçlu Kalem", ProductPrice=25, ProductCategory="Kalem" },
            new() {ProductId = Guid.NewGuid(), ProductName = "Tükenmez Kalem", ProductPrice=15, ProductCategory="Kalem" },
            new() {ProductId = Guid.NewGuid(), ProductName = "Çizgili Defter", ProductPrice=30, ProductCategory="Defter" },
            new() {ProductId = Guid.NewGuid(), ProductName = "Kareli Defter", ProductPrice=30, ProductCategory="Defter" },
            new() {ProductId = Guid.NewGuid(), ProductName = "Sulu Boya", ProductPrice=55, ProductCategory="Boya" },
            new() {ProductId = Guid.NewGuid(), ProductName = "Pastel Boya", ProductPrice=70, ProductCategory="Boya" },
        };

        public static List<Product> ProductList => productList;
    }
}
