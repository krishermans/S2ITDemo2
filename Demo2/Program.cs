﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class Program
    {
        static void Main(string[] args)
        {

            var c = new Customer { Id = "Cust001" };
            Console.WriteLine($"Hello {c.Id}");

            var e = new Employee { Name = "Kris Hermans" };
            Console.WriteLine($"Hello {e.Name}");

        }
    }
}
