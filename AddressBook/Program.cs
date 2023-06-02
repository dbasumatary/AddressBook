namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBook addressBook = new AddressBook();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nPLease enter the choices");
                Console.WriteLine("\n1. Add New Contact\n2. Display the contacts\n3. Edit Contacts\n4. Delete Contacts\n5. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressBook.AddContacts();
                        break;
                    case 2:
                        addressBook.DisplayContacts();
                        break;
                    case 3:
                        addressBook.EditContacts();
                        break;
                    case 4:
                        addressBook.DeleteContact();
                        break;
                    case 5: 
                        flag = false;
                        break;
                }
            }
        }
    }
}