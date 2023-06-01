using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Contacts
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipcode { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return $"First Name: {firstName}, Last Name : {lastName}, Address: {address}, City: {city}, State: {state}, ZIP: {zipcode}, Phone: {phone}, Email : {email}";
        }
    }
}
