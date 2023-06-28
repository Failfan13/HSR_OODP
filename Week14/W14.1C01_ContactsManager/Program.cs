using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a dictionary to store contact information
        Dictionary<string, string> contacts = new Dictionary<string, string>();


        // Prompt the user for input and perform the requested operation
        bool quit = false;
        while (!quit)
        {
            string name = "";

            Console.WriteLine("Enter a command (add, view, remove, list, quit):");
            string command = Console.ReadLine();

            if (command == "add")
            {
                //Complete this section
                Console.WriteLine("Enter the name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the number");
                string number = Console.ReadLine();

                if (name != null && number != null)
                    contacts.Add(name, number);
            }
            else if (command == "view")
            {
                //Complete this section
                Console.WriteLine("Enter the name");
                name = Console.ReadLine();

                if (name != null && contacts.Keys.Contains(name)) Console.WriteLine($"Phone number: {contacts[name]}");
                else Console.WriteLine("Contact not found");
            }
            else if (command == "remove")
            {
                //Complete this section
                Console.WriteLine("Enter the name");
                name = Console.ReadLine();

                if (name != null && contacts.Keys.Contains(name))
                {
                    contacts.Remove(name);
                }
            }
            else if (command == "list")
            {
                //Complete this section
                foreach (KeyValuePair<string, string> contact in contacts)
                {
                    Console.WriteLine(contact.Key + ": " + contact.Value);
                }
            }
            else if (command == "quit")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Invalid command.");
            }
        }
    }
}