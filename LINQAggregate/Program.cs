using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQAggregate
{
    class Program
    {
    

        static void Main(string[] args)
        {
            var list = new List<int> { 1, 8, 3, 2 };
            double result = list.Average();
        }
    }
}