﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Hyunju");
            Console.WriteLine(customer.Id); //1
            Console.WriteLine(customer.Name); //Hyunju
        }
    }
}
