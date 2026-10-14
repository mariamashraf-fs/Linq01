using System;
using LINQ.Models;
using LINQ.DataSources;
using System.Linq;

namespace Assignment_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var products = Source.ProductList;

            #region Question01

            //var q1 = products.Where(p => p.Category == "Seafood");

            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}

            #endregion


            #region Question02

            //var q2 = products.Select(p => p.ProductName);

            //foreach (var item in q2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Question03

            //var q3 = products.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var item in q3)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}

            #endregion

            #region Question04

            //var q4 = products.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var item in q4)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Category: {item.Category}, In Stock: {item.UnitsInStock}");
            //}

            #endregion

            #region Question05

            //var q5 = products.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Price = p.UnitPrice,
            //    StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //});


            // foreach (var item in q5)
            // {
            //     Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, Status: {item.StockStatus}");
            // }

            #endregion

            #region 

            //var q6 = products.Select((p, index) => $"{index + 1}. {p.ProductName}");

            //foreach (var line in q6)
            //{
            //    Console.WriteLine(line);
            //}

            #endregion


        }
    }
}
