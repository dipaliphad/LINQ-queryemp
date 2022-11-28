using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_queryemp
{
    public class Employee
    {
        
        public string Name { get; set; }
        public int salary { get; set; }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>()
            {
                new Employee{Name="Ramesh",salary=49000},
                new Employee{Name="Sam",salary=79000},
                new Employee{Name="Era",salary=50000},
                new Employee{Name="Priya",salary=48000},
            };
            //var result = from e in list select e;
            //Console.WriteLine(result);

            //var result=from e in list
            //           where e.Name.Contains("Ramesh")
            //           select e;

            //var result = from e in list
            //             where e.salary<50000
            //             orderby e.salary descending
            //             select e;

            var result = from e in list
                         where e.Name.Contains("Sam")
                         select e;
        }
    }
}
