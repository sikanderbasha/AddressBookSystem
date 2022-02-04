using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Address
    {
        List<Contacts> address = new List<Contacts>();

        public void AddContact()
        {

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

            System.Console.WriteLine("Enter Email-Id: ");
            contacts.Email = Console.ReadLine();
            Console.WriteLine("Contact details of : " + contacts.FirstName);
            Console.WriteLine("FirstName : " + contacts.FirstName 
                            + "\n" + "LastName : " + contacts.LastName
                            + "\n" + "Address : " + contacts.Address
                            + "\n" + "City : " + contacts.City
                            + "\n" + "State : " + contacts.State
                            + "\n" + "Zip : " + contacts.Zip
                            + "\n" + "PhoneNumber : " + contacts.PhoneNumber
                            + "\n" + "Email : " + contacts.Email);

            address.Add(contacts);
           
        }
    }
}
