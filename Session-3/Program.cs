using Microsoft.EntityFrameworkCore;
using Session_3.Contexts;

namespace Session_3
{
    internal class Program
    {
        static void Main()
        {

            #region Loading Navigational Property 

            //using AppDbContext context = new AppDbContext();


            //var department = new List<Department>()
            //{
            //    new Department() { Name = "HR"},
            //    new Department() { Name = "PR"},
            //    new Department() { Name = "IT"}
            //};

            //var employees = new List<Employee>()
            //{
            //    new Employee() { Name= "Ahmed Ali" , Address = "Cairo" ,Age = 29 , Salary =12000 , DeptId = 100 },
            //    new Employee() { Name= "Omar Ali" , Address = "Giza" ,Age = 32 , Salary =15000 , DeptId = 100 },
            //    new Employee() { Name= "Mona Ali" , Address = "Cairo" ,Age = 25 , Salary =13000 , DeptId = 100 },
            //    new Employee() { Name= "Ahmed Khaled" , Address = "Nas City" ,Age = 30 , Salary =17000 , DeptId = 200 },
            //    new Employee() { Name= "Mariam Ahmed" , Address = "Alex" ,Age = 24 , Salary =1000 , DeptId = 200 },
            //    new Employee() { Name= "Maha Mahmoud" , Address = "Hurghada" ,Age = 26 , Salary =14000 , DeptId = 300 },
            //    new Employee() { Name= "Mohamed Osman" , Address = "Hurghada" ,Age = 24 , Salary =19000 , DeptId = 100 }
            //};

            //context.Departments.AddRange(department);
            //context.Employees.AddRange(employees);

            //context.SaveChanges();



            //var employee = context.Employees.FirstOrDefault(E => E.Id == 100);

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDte ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");


            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //}


            // NOTE : EF Core Don't Loading Any Navigation Property 

            // EF Core Loading Navigation Property : 
            // 1- Ecplicit Loading 
            // 2- Egar Loading
            // 3- Lazing Loading


            #region 1- Ecplicit Loading 

            // 1- Ecplicit Loading :

            //var employee = context.Employees.FirstOrDefault(E => E.Id == 100);

            ////context.Entry(employee).Reference("WorkFor").Load();  // Explist Loading 
            //context.Entry(employee).Reference(E => E.WorkFor).Load();  // Explist Loading 

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDte ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");


            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);

            //context.Entry(department).Collection( D => D.Employees).Load(); //  Ecplicit Loading 


            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region 2- Egar Loading
            // 2- Egar Loading

            //var employee = context.Employees.Include(E => E.WorkFor).FirstOrDefault(E => E.Id == 100);

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDte ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");


            //var department = context.Departments.Include(D => D.Employees).FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #region 3- Lazing Loading
            //3 - Lazing Loading
            // 3 - 1 - Instal Package: Proxies
            // 3 - 2 - Update OnConfiguring() , Use UseLazyLoadingProxies
            // 3 - 3 - Make All Entities Public
            // 3 - 4 - Make All Navigational Properties Virtual


            //var employee = context.Employees.FirstOrDefault(E => E.Id == 100);

            //Console.WriteLine(employee?.Id ?? 0);
            //Console.WriteLine(employee?.Name ?? "NA");
            //Console.WriteLine(employee?.Salary ?? 0.0f);
            //Console.WriteLine(employee?.Address ?? "NA");
            //Console.WriteLine(employee?.HiringDte ?? DateTime.Now);
            //Console.WriteLine(employee?.DeptId ?? 0);
            //Console.WriteLine(employee?.WorkFor?.Name ?? "NA");


            //var department = context.Departments.FirstOrDefault(D => D.Id == 100);

            //Console.WriteLine(department.Name);

            //foreach (var item in department.Employees)
            //{
            //    Console.WriteLine(item.Name);
            //} 
            #endregion

            #endregion

            #region Join Operators - Join inner
            // Join Operators - Join inner

            /*
             select  E.id , E.name , D.Name
            from employee E , Department 
            Where D.Id = E.DeptId  --- > PK = FK
             */

            //using AppDbContext context = new AppDbContext();


            // Fluent Syntax 
            //var result = context.Employees.Join(context.Departments, E => E.DeptId, D => D.Id, (E, D)
            //    => new
            //    {
            //        EmpID = E.Id,
            //        EmpName = E.Name,
            //        DeptID = D.Id,
            //        DeptName = D.Name
            //    }).Where(E => E.DeptName == "HR");

            //// Query Expression

            //result = from E in context.Employees
            //         join D in context.Departments
            //         on E.DeptId equals D.Id
            //         where D.Name == "HR"
            //         select new
            //         {
            //             EmpID = E.Id,
            //             EmpName = E.Name,
            //             DeptID = D.Id,
            //             DeptName = D.Name
            //         };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Traking vs NoTraking 
            // Traking vs NoTraking 

            //using AppDbContext context = new AppDbContext();

            //var result = context.Employees.FirstOrDefault(E => E.Id == 100);

            //Console.WriteLine(context.Entry(result).State);

            //Console.WriteLine(result.Name); 
            #endregion

            #region Local - Remote 
            // Local - Remote 

            //using AppDbContext context = new AppDbContext();


            // Remotly 
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();
            //context.Employees.Any();



            //context.Employees.Load();

            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any();
            //context.Employees.Local.Any(); 
            #endregion

            // DB : 





        }
    }
}
