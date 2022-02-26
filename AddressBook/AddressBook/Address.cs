using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Address
    {
        List<Contacts> address = new List<Contacts>();
        Contacts contact = new Contacts();
        public void AddContact()
        {
            Console.WriteLine("Please confirm how much contact you want to create:");
            int Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= Count; i++)
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

        public void EditContact(string FirstName)
        {       
            foreach (var data in address)
            {
                if (data.FirstName == FirstName)
                {
                    contact = data;
                    Console.WriteLine("\n 1. First name\n 2. Last name\n 3. Address\n 4. City\n 5. State\n 6. Zipcode\n 7. Phone number\n 8. Email ID\n 9. Exit");                                         
                    int option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("Enter the First name");
                                contact.FirstName = Convert.ToString(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("Enter the Last name");
                                contact.LastName = Convert.ToString(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("Enter the Address");
                                contact.Address = Convert.ToString(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("Enter the City");
                                contact.City = Convert.ToString(Console.ReadLine());
                                break;
                            case 5:
                                Console.WriteLine("Enter the State");
                                contact.State = Convert.ToString(Console.ReadLine());
                                break;
                            case 6:
                                Console.WriteLine("Enter the Zip Code");
                                contact.Zip = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 7:
                                Console.WriteLine("Enter the Phone Number");
                                contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 8:
                                Console.WriteLine("Enter the Email");
                                contact.Email = Convert.ToString(Console.ReadLine());
                                break;
                            default:
                                Console.WriteLine("Enter Correct option!");
                                break;
                        }

                        Display();
                        return;
                    

                }
            }
        }

        public void DeleteContact(string FirstName)
        {
            Contacts contact = new Contacts();
            foreach (var data in address)
            {
                if (data.FirstName == FirstName)
                {
                    contact = data;
                    address.Remove(contact);
                    Console.WriteLine("{0} contact details deleted", contact.FirstName);
                    return;
                }
            }
        }
        public void Display()
        {
            foreach (var data in address)
            {
                Console.WriteLine("Updated contact details of : " + data.FirstName);
                Console.WriteLine("FirstName : " + data.FirstName
                            + "\n" + "LastName : " + data.LastName
                            + "\n" + "Address : " + data.Address
                            + "\n" + "City : " + data.City
                            + "\n" + "State : " + data.State
                            + "\n" + "Zip : " + data.Zip
                            + "\n" + "PhoneNumber : " + data.PhoneNumber
                            + "\n" + "Email : " + data.Email);
            }
        }
    }
}
