using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CreateContact
    {
        /// <summary>
        /// Generates the AddressBook.
        /// </summary>
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

            
            Console.WriteLine("First Name:{0}   Last name:{1}   Address:{2}   City:{3}   State:{4} zipcode:{5}  Phone number:{6} email:{7}", contact[0], contact[1],contact[2], contact[3], contact[4], contact[5], contact[6], contact[7]);
        }
    }
}
