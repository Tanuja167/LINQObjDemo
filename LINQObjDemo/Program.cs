using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQObjDemo
{

    public class Employee
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string City { get; set; }
        public int Salary { get;set; }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Employees = new List<Employee>()
            {
               new Employee{Id=1, Name="Tanu", City="Pune", Salary=25000},
               new Employee{Id=2, Name="alisha", City="Mumbai", Salary=25500},
               new Employee{Id=3, Name="Rutuja", City="Nashik", Salary=55000},
               new Employee{Id=4, Name="Chinmay", City="Satara", Salary=25080},
               new Employee{Id=5, Name="Sagar", City="Mumbai", Salary=67000},
               new Employee{Id=6, Name="Prasad", City="Solapur", Salary=24000},
               new Employee{Id=7, Name="Pooja", City="Pune", Salary=56000},
               new Employee{Id=8, Name="Anushka", City="Kolhapur", Salary=34000},
               new Employee{Id=9, Name="Anurag", City="Aurangabad", Salary=25000},
               new Employee{Id=10, Name="Kiran", City="Kerla", Salary=20000},
               new Employee{Id=11, Name="Payal", City="Mumbai", Salary=27000},
               
            };

            var result = from e in Employees
                         where e.City == "Pune"
                         select e;

            /*foreach(Employee item in result)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }*/

            var result2 = from e in Employees
                          where e.Name.StartsWith("P")
                          select e;
/*
            foreach (Employee item in result2)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }
*/
            var result3 = from e in Employees
                          where e.Salary > 2400 && e.City == "Pune"
                          select e;

           /* foreach (Employee item in result3)
            {
                Console.WriteLine($"{item.Id},{item.Name},{item.City},{item.Salary}");
            }*/

            //var result4 = Employees.Where(x => x.City == "Mumbai").ToList();
            var result4 = Employees.Where(x => x.City == "Pune").OrderBy(x => x.Salary).ToList();
            foreach (Employee item in result4)
            {
                Console.WriteLine($"{item.Id}, {item.Name},{item.City},{item.Salary}");
            }

            Console.ReadLine();
        }
        
    }
}
