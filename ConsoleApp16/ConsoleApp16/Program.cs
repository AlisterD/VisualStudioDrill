﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee("Sample", "Student");
            sample.sayName();

            Console.ReadLine();

        }
    }
}
