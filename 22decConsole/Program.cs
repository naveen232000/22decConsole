using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _22decConsole
{
    internal class Program
    {
        public List<Employee> employees;
        public Program() {
            employees = new List<Employee>() {
            new Employee() { EmpId = 1, Emp_FName = "Naveen", Emp_Lname = "Madhesan", Address = "IND", Salery = 9000.0 },
            new Employee() { EmpId = 1, Emp_FName = "Jon", Emp_Lname = "Son", Address = "US", Salery = 8000.0 },
            new Employee() { EmpId = 3, Emp_FName = "Tom", Emp_Lname = "Jos", Address = "Eu", Salery = 9200.60 },
            new Employee() { EmpId = 4, Emp_FName = "Neon", Emp_Lname = "Due", Address = "US", Salery = 9450.450 },
            new Employee() { EmpId = 5, Emp_FName = "Nivi", Emp_Lname = "Sri", Address = "IND", Salery = 7000.0 },
        };

        }
    
        public void GetEmployee() {
            employees.ToList(). ForEach(e => Console.WriteLine($"{e.EmpId}\t{e.Emp_FName}\t{e.Emp_Lname}\t{e.Address}\t\t{e.Salery}"));

        }
        public void GetEmployee(int id)
        {
            //var recordName = from emp in employees where emp.EmpId == id select emp;
            //foreach (var allrow in recordName) 
            //{ 
            //    Console.WriteLine(allrow.Emp_FName);
            //}

            Employee gtEmp = employees.Where(e=>e.EmpId == id).FirstOrDefault();
            if (gtEmp == null )
            {
                Console.WriteLine($"Their is no Employee with {id}");
            }
            else
            {
                Console.WriteLine($"{gtEmp.EmpId}\t{gtEmp.Emp_FName}\t{gtEmp.Emp_Lname}\t{gtEmp.Address}\t\t{gtEmp.Salery}");
            }
        }
        public void GetEmployeeByFN(string FName)
        {
            Employee gtEmp = employees.Where(e => e.Emp_FName == FName).FirstOrDefault();
            if (gtEmp == null)
            {
                Console.WriteLine($"Their is no Employee with {FName}");
            }
            else
            {
                Console.WriteLine($"{gtEmp.EmpId}\t{gtEmp.Emp_FName}\t{gtEmp.Emp_Lname}\t{gtEmp.Address}\t\t{gtEmp.Salery}");
            }
        }
        public void GetEmployeeByLN(string LName)

        {
          

            Employee gtEmp = employees.Where(e => e.Emp_Lname == LName).FirstOrDefault();
            if (gtEmp == null)
            {
                Console.WriteLine($"Their is no Employee with {LName}");
            }
            else
            {
                Console.WriteLine($"{gtEmp.EmpId}\t{gtEmp.Emp_FName}\t{gtEmp.Emp_Lname}\t{gtEmp.Address}\t\t{gtEmp.Salery}");
            }
        }
        static void Main(string[] args)
        {
            Program employee = new Program();
            employee.GetEmployee(1);
            employee.GetEmployeeByFN("Jon");
            employee.GetEmployeeByLN("Srii");
           

            Console.ReadLine();


        }
    }
}
