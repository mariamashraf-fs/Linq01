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

        }
    }
}
