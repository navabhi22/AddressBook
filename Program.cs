using System;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("AddressBook is empty Enter the number of contacts you want to create");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                CreateContact contact = new CreateContact();
                contact.CreateContacts();
            }
        }
    }
}