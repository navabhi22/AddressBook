using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateContact
    {
        public void CreateContacts()
        {
            string[] contact = new string[8];
            Console.WriteLine("Enter the First Name");
            contact[0] = Console.ReadLine();
            Console.WriteLine("Enter the Last Name");
            contact[1] = Console.ReadLine();
            Console.WriteLine("Enter the Address");
            contact[2] = Console.ReadLine();
            Console.WriteLine("Enter the City");
            contact[3] = Console.ReadLine();
            Console.WriteLine("Enter the State");
            contact[4] = Console.ReadLine();
            Console.WriteLine("Enter the zip code");
            contact[5] = Console.ReadLine();
            Console.WriteLine("Enter the phone number");
            contact[6] = Console.ReadLine();
            Console.WriteLine("Enter the email");
            contact[7] = Console.ReadLine();

            Console.WriteLine("First Name    Last name    Address    City    State  zipcode   Phone number  email");
            for (int i = 0; i < contact.Length; i++)
            {
                Console.Write(contact[i]+"  ");

            }
            Console.WriteLine( "  ");
        }
    }
}
