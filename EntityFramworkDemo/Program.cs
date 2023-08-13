using System;
using System.Linq;

namespace NorthwindDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sql ve ilişkisel Veritabanı
            //ADO.NET
            //Entity Framework - Bir ORM - Objcet relational mapping
            //NHibernate 
            //Dapper

            GetAll();
            //GetProductsByCategory(1);

        }

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            //foreach (var product in northwindContext.Products)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            foreach (var personel in northwindContext.Personels)
            {
                Console.WriteLine("{0} / {1} / {2}", personel.Id,personel.Name,personel.Surname);
            }
        }

        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p=>p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }

    }
}
