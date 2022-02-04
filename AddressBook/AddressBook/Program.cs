using System;
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
            Console.WriteLine("Welcome to Address Book System!");
            Address address = new Address();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n 1.Add Contact."
                                + "\n 2.Edit Contact."
                                + "\n 3.Delete Contact."
                                + "\n 4.Exit.");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        address.AddContact();
                        break;
                    case 2:
                        Console.WriteLine("Enter the First Name To Edit Contact : ");
                        string firstName = Convert.ToString(Console.ReadLine());
                        address.EditContact(firstName);
                        break;
                    case 3:
                        Console.WriteLine("Enter First Name To Delete Contact : ");
                        string Delete = Convert.ToString(Console.ReadLine());
                        address.DeleteContact(Delete);
                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option!!!");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
