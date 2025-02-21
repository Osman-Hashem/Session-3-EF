using InheritavceExample.Contexts;
using InheritavceExample.Models;

namespace InheritavceExample
{
    internal class Program
    {
        static void Main()
        {


            // 3 Ways To Generate Schema 
            // 1- TPS  : Table Per Class
            // 2- TPH  : Table Per Hierarcht
            // 3- TPCC : Table Per Concert Class 

            /////////////////////////////////////////

            using AppDbContext context = new AppDbContext();

            //FullTimeEmployee fullTime01 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Ali",
            //    Address = "Cairo",
            //    Email = "AhmedAli@gmail.com",
            //    Salary = 12000
            //};

            //FullTimeEmployee fullTime02 = new FullTimeEmployee()
            //{
            //    Name = "Ahmed Khaled",
            //    Address = "Alex",
            //    Email = "AhmedKhaled@gmail.com",
            //    Salary = 15000,
            //};

            //FullTimeEmployee fullTime03 = new FullTimeEmployee()
            //{
            //    Name = "Mariam Ali",
            //    Address = "Giza",
            //    Email = "MariamAli@gmail.com",
            //    Salary = 13000,
            //};

            //context.FullTimeEmployees.Add(fullTime03);
            //context.SaveChanges();
            //////////
            ///


            //PartTimeEmployee partTime01 = new PartTimeEmployee()
            //{
            //    Name = "Ahmed Mohamed",
            //    Address = "Cairo",
            //    Email = "Ahmed@gmail.com",
            //    NumberOfHours = 120,
            //    HourRate = 200
            //};



            //PartTimeEmployee partTime02 = new PartTimeEmployee()
            //{
            //    Name = "Maha Khaled",
            //    Address = "Alex",
            //    Email = "AhmedKhaled@gmail.com",
            //    NumberOfHours = 200,
            //    HourRate = 300
            //};


            //PartTimeEmployee partTime03 = new PartTimeEmployee()
            //{
            //    Name = "Mariam Rahim",
            //    Address = "Giza",
            //    Email = "Mariam@gmail.com",
            //    HourRate = 300,
            //    NumberOfHours = 100
            //};

            //context.PartTimeEmployees.Add(partTime01);
            //context.PartTimeEmployees.Add(partTime02);
            //context.PartTimeEmployees.Add(partTime03);


            //context.SaveChanges();


            ///-///////////////
            ///

            //foreach (var item in context.FullTimeEmployees)
            //{
            //    Console.WriteLine(item.Name);
            //}


            //var Result = context.FullTimeEmployees.FirstOrDefault(E => E.Id == 4);

            //Console.WriteLine(Result.Name);













        }
    }
}
