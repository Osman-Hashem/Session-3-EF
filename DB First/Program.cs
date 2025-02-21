using DB_First.Data.Contexts;
using DB_First.Data.Model;

namespace DB_First
{
    internal class Program
    {
        static void Main()
        {
            using AppDbContext context = new AppDbContext();

            //Category category = new Category()
            //{
            //    CategoryName = "Hamada",
            //    Description = "Hamada"
            //};


            //context.Categories.Add(category);
            //context.SaveChanges();


            //-/-/-/-/-/-////////////--------------------


            //var result = context.Categories.ToList();

            //foreach (var item in context.Categories)
            //{
            //    Console.WriteLine(item.CategoryName);
            //    Console.WriteLine();
               
            //        foreach (var product in item.Products)
            //        {
            //            Console.WriteLine(product);
            //        }
            //}










        }

    }
}
