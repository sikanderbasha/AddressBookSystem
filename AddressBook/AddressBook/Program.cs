﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Welcome to Address Book System!");

            Address address = new Address();
            address.AddContact();
            Console.ReadKey();
        }
    }
}
