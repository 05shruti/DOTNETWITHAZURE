using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Linq
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StudentAge { get; set; }
    }
    class Class1
    {
        public static void Main()
        {

            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("Two");
            mixedList.Add("Three");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Sejal" });

            var intResult = from s in mixedList.OfType<int>() select s;
            var intResult1 = mixedList.OfType<int>();

            Console.WriteLine("=======OfType=========");
            Console.WriteLine("Linq ");
            foreach (var item in intResult)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Linq to entity");
            foreach (var item in intResult1)
            {
                Console.WriteLine(item);
            }
            IList<Student> studentList = new List<Student>() {

                new Student(){StudentID=1,StudentName="Sejal",StudentAge=20},
                  new Student(){StudentID=2,StudentName="Nikki",StudentAge=18},
                    new Student(){StudentID=3,StudentName="Apurva",StudentAge=15},
                     new Student(){StudentID=4,StudentName="Arbina",StudentAge=21},
                      new Student(){StudentID=5,StudentName="Purva",StudentAge=25}
            };

            var orderbyResult = from s in studentList orderby s.StudentName select s;
            var orderbyResult1 = studentList.OrderBy(x => x.StudentName);

            Console.WriteLine("============Order by=======");
            foreach (var item in orderbyResult)
            {
                Console.WriteLine(item.StudentName);
            }
            Console.WriteLine("============================");
            foreach (var item in orderbyResult1)
            {
                Console.WriteLine(item.StudentName);
            }

            var orderbyRasultDesc = from s in studentList orderby s.StudentName descending select s;
            var orderbyResultDesc2 = studentList.OrderByDescending(x => x.StudentName);

            var containResult = (from id in studentList select id.StudentID).Contains(2);
            Console.WriteLine(containResult);

            Console.WriteLine("-========================");
            IList<int> intList = new List<int>() { 1, 2, 3, 4, 5 };
            bool result = intList.Contains(10);
            Console.WriteLine(result);

            Console.WriteLine("-==============Aggregate==========");
            IList<string> strList = new List<string>() { "One", "Two", "Three", "Four" };
            var separate = strList.Aggregate((s1, s2) => s1 + "," + s2);
            Console.WriteLine(separate);

            var average = intList.Average();
            Console.WriteLine(average);
            Console.WriteLine("============================");
            var min = intList.Min();
            Console.WriteLine(min);
            Console.WriteLine("============================");
            var count = intList.Count();
            Console.WriteLine(count);
            Console.WriteLine("============================");
            var max = intList.Max();
            Console.WriteLine(max);
            Console.WriteLine("============================");
            var sum = intList.Sum();
            Console.WriteLine(sum);


            Console.WriteLine("=========DEFAULTIFEMPTY==========");
            IList<string> emptyList = new List<string>();

            var newList1 = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("None");

            Console.WriteLine("Count: {0}", newList1.Count());
            Console.WriteLine("Value: {0}", newList1.ElementAt(0));

            Console.WriteLine("Count: {0}", newList2.Count());
            Console.WriteLine("Value: {0}", newList2.ElementAt(0));
        }
    }
}