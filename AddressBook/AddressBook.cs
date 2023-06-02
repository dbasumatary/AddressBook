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

        public void DisplayContacts()
        {
            foreach (Contacts contact in contactList)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
