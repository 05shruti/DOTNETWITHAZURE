using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Day_9
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSalary { get; set; }

        public void GetData()
        {
            Console.WriteLine("Please enter your EmployeeID");
            EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your EmployeeName");
            EmployeeName = Console.ReadLine();
            Console.WriteLine("Please enter your Salary");
            EmployeeSalary = Convert.ToInt32(Console.ReadLine());
        }
    }
    class Class3
    {
        public static void Main()
        {
            List<Employee> employeeList = new List<Employee>();
            Employee e = new Employee();
            e.GetData();
            employeeList.Add(e);
            //c# to json
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(e);
            Console.WriteLine(json);
            //json to c#
            var eObj = Newtonsoft.Json.JsonConvert.DeserializeObject<Employee>(json);
            FileStream f = new FileStream("emp.json", FileMode.Append, FileAccess.Write);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine(e.EmployeeID);
            s.WriteLine(e.EmployeeName);
            s.WriteLine(e.EmployeeSalary);
            s.Flush();
            s.Close();
            f.Close();

            //reading json
            FileStream fsR = new FileStream("emp.Json", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fsR);
            Console.WriteLine("======Content from file========");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            while (e != null)
            {
                Console.WriteLine("Employee ID:" + e.EmployeeID);
                e.EmployeeID = Convert.ToInt32(sr.ReadLine());
                Console.WriteLine("Employee Name: " + e.EmployeeName);
                e.EmployeeName = sr.ReadLine();
                Console.WriteLine("Employee Salary: " + e.EmployeeSalary);
                e.EmployeeSalary = Convert.ToInt32(sr.ReadLine());
                break;
            }
            sr.Close();
            fsR.Close();
        }
    }
}