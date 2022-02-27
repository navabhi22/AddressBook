using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddMultiple
    {
        /// <summary>
        /// Creates Multiple Contact.
        /// </summary>
        public void AddNewContact()
        {

            Console.WriteLine("A to Add Person");
            Console.WriteLine("Q to Quit");
            string UserInput = Console.ReadLine();
            switch (UserInput)
            {
                case "A":
                    CreateContact contact = new CreateContact();
                    contact.CreateContacts();
                    AddressBook addressBook = new AddressBook();
                    addressBook.AddrsBook();
                    break;
                case "Q":
                    break;
                default:
                    Console.WriteLine("Choose Valid Option");
                    break;
            }
        }

    }
}
