// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP1 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product product1 = new();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase    //camelCase
            //case sensitive
            ProductManager productManager = new();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);    //"Kamera"


            //int, double, bool... değer tip
            //diziler, class, abstract class, interface... referans tip


            Console.ReadLine();
        }
    }
}
