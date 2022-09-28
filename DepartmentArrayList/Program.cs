using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DepartmentEmp
{
    public class Employee
    {
        public string ename { get; set; }
        public string city { get; set; }
        public double sal { get; set; }

    }
    public class Department
    {
        public int No { get; set; }
        public string Name { get; set; }

        public ArrayList Employees { get; set; }

    }
    public class Program
    {
        static void Main(string[] args)
        {
           ArrayList e1=new ArrayList();
            {
                e1.Add(new Employee { ename = "Rahul", city = "Pune", sal = 20000 });
                e1.Add(new Employee { ename = "Sham", city = "satara", sal = 26000 });
            };

           ArrayList   e2 = new ArrayList();
            {
                e2.Add(new Employee { ename = "Radha", city = "Sangli", sal = 560000 });
                e2.Add(new Employee { ename = "Gopal", city = "Bihar", sal = 40500 });
                e2.Add(new Employee { ename = "Kunal", city = "Uttrakhand", sal = 10000 });
            };
            ArrayList e3 = new ArrayList();
            {
                e3.Add( new Employee{ename="Ramesh",city="Madhyapradesh",sal=50000 });
                e3.Add(new Employee { ename = "Sumit", city = "Zarkhand", sal = 40000 });
                e3.Add(new Employee { ename = "Kumar", city = "Bhopal", sal = 30000 });
            };
             ArrayList arrayList = new ArrayList();
           {
                arrayList.Add(new Department { No = 1, Name = "IT", Employees = e1 });
                arrayList.Add(new Department { No = 2, Name = "Science", Employees = e2 });
                arrayList.Add(new Department { No = 3, Name = "Art", Employees = e3 });

           };
            foreach (Department d in arrayList)
            {
                Console.WriteLine($"{d.No} {d.Name}");
                foreach (Employee e in d.Employees)
                {
                    Console.WriteLine($"\t {e.ename} -> {e.city}-> {e.sal}");
                }
            }

        }
    }
}
