using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedStruct
{    
    struct Company
    {
         public struct Employee
        {
            public Employee(string empName, int empID)
            {
                EmpName = empName;
                EmpID = empID;
            }
            string EmpName { get; set; }
            int EmpID { get; set; }
            public void printAll()
            {
                Console.WriteLine("Employee Name: " + EmpName);
                Console.WriteLine("Employee ID: " + EmpID);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company c = new Company();
            Console.ReadLine();
        }
    }
}
