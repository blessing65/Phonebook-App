using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebookApp
{
    public class Contacts
    {
        
        static public List<Contacts> AllContacts = new List<Contacts>();

        string Name {  get; set; }
        string Address { get; set; }
        int PhoneNumber { get; set; }


        public void AddContact()
        {
            User user = new User();
            Console.Clear();
            Console.WriteLine("Enter Name of Contacts");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Contacts Phone Number");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Contacts Address");
            string address = Console.ReadLine();
            Contacts newContact = new Contacts();
            newContact.Name = name;
            newContact.PhoneNumber = phoneNumber;
            newContact.Address = address;
            foreach(var contact in AllContacts)
            {
                if(contact.PhoneNumber == phoneNumber)
                {
                    Console.WriteLine("A contact with this phone number already exist.");
                    Console.ReadKey();
                    user.userOptions();
                }
            }
            AllContacts.Add(newContact);

            Console.WriteLine($"{name} has been added to contacts");
            Console.ReadKey();
            user.userOptions();
        }
        public void RemoveContact()
        {
            User user = new User();
            Console.Clear();
            Console.WriteLine("Enter number of contact");
            int no = Convert.ToInt32(Console.ReadLine());
            foreach(var contact in AllContacts)
            {
                if(contact.PhoneNumber == no)
                {
                    AllContacts.Remove(contact);
                    Console.WriteLine($"{contact.Name} has been removed from Contacts");
                    Console.ReadKey();
                    user.userOptions();
                }
            }
            Console.WriteLine("There is no contact with this phone number.");
            Console.ReadKey();
            user.userOptions();
        }
        public void getAllContacts() 
        {
            User user = new User();
            Console.Clear();
            Console.WriteLine("========== All Contacts ===========");
            if(AllContacts.Count < 1)
            {
                Console.WriteLine("There is no Contact");
                Console.ReadKey();
                user.userOptions();
            }
            else 
            {
                foreach (var contact in AllContacts)
                {
                    Console.WriteLine($"Name => {contact.Name}" );
                    Console.WriteLine($"Phone Number => {contact.PhoneNumber}");
                    Console.WriteLine($"Address => {contact.Address}");
                }
                Console.ReadKey();
                user.userOptions();
            }
            
        }
        public void getContact()
        {
            User user = new User();
            Console.Clear();
            Console.WriteLine("Enter Name Of Contact");
            var name = Console.ReadLine();
            foreach (var contact in AllContacts)
            {
                if(contact.Name == name)
                {
                    Console.WriteLine($"Name => {contact.Name}");
                    Console.WriteLine($"Address => {contact.Address}");
                    Console.WriteLine($"Phone Number => {contact.PhoneNumber}");
                    Console.ReadKey();
                    user.userOptions();
                }

            }
            Console.WriteLine("There is no contact with this name.");
            Console.ReadKey();
            user.userOptions();
        }
    }
}
