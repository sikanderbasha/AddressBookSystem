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

            Contacts contacts = new Contacts();
            System.Console.WriteLine("Enter First Name: ");
            contacts.FirstName = Console.ReadLine();

            System.Console.WriteLine("Enter Last Name: ");
            contacts.LastName = Console.ReadLine();

            System.Console.WriteLine("Enter Adress: ");
            contacts.Address = Console.ReadLine();

            System.Console.WriteLine("Enter City: ");
            contacts.City = Console.ReadLine();

            System.Console.WriteLine("Enter State: ");
            contacts.State = Console.ReadLine();

            System.Console.WriteLine("Enter Zip: ");
            contacts.Zip = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Phone Number: ");
            contacts.PhoneNumber = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter Email-ID: ");
            contacts.Email = Console.ReadLine();
        }
    }
}
