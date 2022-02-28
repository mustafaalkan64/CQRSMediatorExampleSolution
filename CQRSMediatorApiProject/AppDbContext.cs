using CQRSMediatorApiProject.Models;
using System;
using System.Collections.Generic;

namespace CQRSMediatorApiProject
{
    public static class AppDbContext
    {
        static List<Products> productList = new List<Products> {
         new() { Id = 1, Name = "Kalem", Price = 100, Quantity = 10, CreateTime = DateTime.Now },
         new() { Id = 2, Name = "Silgi", Price = 200, Quantity = 20, CreateTime = DateTime.Now },
         new() { Id = 3, Name = "Defter", Price = 300, Quantity = 30, CreateTime = DateTime.Now },
         new() { Id = 4, Name = "Kitap", Price = 400, Quantity = 40, CreateTime = DateTime.Now },
         new() { Id = 5, Name = "Tahta Kalem", Price = 500, Quantity = 50, CreateTime = DateTime.Now },
         new() { Id = 6, Name = "Tükenmez Kalem", Price = 600, Quantity = 60, CreateTime = DateTime.Now }
        };
        public static List<Products> ProductList => productList;
    }
}
