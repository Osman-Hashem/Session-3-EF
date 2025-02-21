using DB_First_Using_Ef_Core_Power_Tools.Data.Contexts;
using Microsoft.EntityFrameworkCore;

namespace DB_First_Using_Ef_Core_Power_Tools
{
    internal class Program
    {
        static void Main()
        {
            //using NorthwindDbContext context = new NorthwindDbContext();

            //var result = context.Categories.ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.CategoryName);
            //}

            // Run SQL Query 
            // 1- Select Statment : FromSqlRaw() , FromSqlInterploated()

            //var result = context.Categories.FromSqlRaw("Select * From Categories");

            //var result = context.Customers.FromSqlRaw("Select * From Customers where Country = Germany");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.Country);
            //}





            // 2- DML Statments [Update - Insert - Delete] ExecutionSelRaw() , ExecutionSqlInterploated()


            //context.Database.ExecuteSqlRaw("Update Products Set UnitsInStock = 40 where ProductID = 1");


        }
    }
}
