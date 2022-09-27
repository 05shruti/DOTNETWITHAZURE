using System;
using System.Collections.Generic;
using System.Linq;
namespace LINQDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>() { "Shruti", "Mandeep", "Chuchu", "Pandey", "Singh" };
            //Using Method Syntax
            //This method belongs to System.Collections.Generic namespace
            var IsExistsMS1 = namesList.Contains("Shruti");
            //This method belongs to System.Linq namespace
            var IsExistsMS2 = namesList.AsEnumerable().Contains("Shruti");
            //Using Query Syntax
            var IsExistsQS = (from num in namesList
                              select num).Contains("Shruti");
            Console.WriteLine(IsExistsQS);
            Console.ReadKey();
        }
    }
}