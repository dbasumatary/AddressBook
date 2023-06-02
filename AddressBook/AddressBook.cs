using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBook
    {
        List<Contacts> contactList = new List<Contacts>();

        public Contacts AddContacts()
        {
            Contacts contactNew = new Contacts();

            Console.Write("Enter the First Name of Contact: ");
            contactNew.firstName = Console.ReadLine();

            if (contactList.Find(x => x.firstName.ToLower() == contactNew.firstName.ToLower()) != null)
            {
                Console.WriteLine("The name already exists in address book");
                AddContacts();
                return null;
            }

            Console.Write("Enter the Last Name: ");
            contactNew.lastName = Console.ReadLine();
            Console.Write("Enter the City: ");
            contactNew.city = Console.ReadLine();
            Console.Write("Enter the State: ");
            contactNew.state = Console.ReadLine();
            Console.Write("Enter the address: ");
            contactNew.address = Console.ReadLine();
            Console.Write("Enter the Zip Code: ");
            contactNew.zipcode = Console.ReadLine();
            Console.Write("Enter the Phone: ");
            contactNew.phone = Console.ReadLine();
            Console.Write("Enter the email: ");
            contactNew.email = Console.ReadLine();

            contactList.Add(contactNew);
            return contactNew;
        }

        public void EditContacts()
        {
            Console.Write("Enter the name whose contact details you want to edit: ");
            string userName = Console.ReadLine();

            foreach (Contacts contact in contactList)
            {
                if (contact.firstName == userName)
                {
                    Console.WriteLine("\nEnter which option you want to edit. ");
                    Console.WriteLine("\n1. First Name\n2. Last Name\n3. Address\n4. City\n5. State\n6. Zip Code\n7. Phone Number\n8. Email ");
                    int Choice = Convert.ToInt32(Console.ReadLine());
                    switch (Choice)
                    {
                        case 1:
                            Console.Write("Enter the First name to be updated: ");
                            contact.firstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Enter the Last name to be updated: ");
                            contact.lastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Enter the Address to be updated: ");
                            contact.address = Console.ReadLine();
                            break;
                        case 4:
                            Console.Write("Enter the City to be updated: ");
                            contact.city = Console.ReadLine();
                            break;
                        case 5:
                            Console.Write("Enter the State to be updated: ");
                            contact.state = Console.ReadLine();
                            break;
                        case 6:
                            Console.Write("Enter the Zip Code to be updated: ");
                            contact.zipcode = Console.ReadLine();
                            break;
                        case 7:
                            Console.Write("Enter the Phone Number to be updated: ");
                            contact.phone = Console.ReadLine();
                            break;
                        case 8:
                            Console.Write("Enter the Email to be updated: ");
                            contact.email = Console.ReadLine();
                            break;
                        default:
                            Console.Write("Please enter the correct input");
                            break;
                    }
                    Console.WriteLine("\nThe updated contact is:");
                    DisplayContacts();
                    break;
                }
                else
                {
                    Console.WriteLine("\nNo contact exists with this name. Please enter the correct name.");
                }
            }
        }

        public void DisplayContacts()
        {
            foreach (Contacts contact in contactList)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
