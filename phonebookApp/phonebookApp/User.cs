using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebookApp
{
    public class User
    {
        public string Name;
        public string Address;
        public int phoneNumber;

        static public List<User> AllUsers = new List<User>();

        public void login()
        {
            Console.Clear();
            Console.WriteLine("Enter phoneNumber");
            int phoneNo = Convert.ToInt32(Console.ReadLine());
            foreach (var user in AllUsers)
            {
                if(user.phoneNumber == phoneNo)
                {
                    Console.WriteLine($"Welcome {user.Name}");
                    userOptions();
                }
            }
            
        }

        public void signUp()
        {
            Console.Clear();
            Console.WriteLine("Enter Your Name");
            string name = Console.ReadLine();
            Console.WriteLine("Phone Number:");
            int phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Address");
            string address = Console.ReadLine();
            User newuser = new User();
            newuser.Name = name;
            newuser.Address = address;
            newuser.phoneNumber = phoneNumber;
            addUser(newuser);
        }

        public void addUser(User newUser)
        {
            foreach(var user in AllUsers)
            {
                if (user.phoneNumber == newUser.phoneNumber) {
                    Console.WriteLine("There is already a user with this phone number");
                    signUp();
                }

            }
            AllUsers.Add(newUser);
            userOptions();
        }

        public void removeUser()
        {
            Console.Clear();
            Console.WriteLine("Enter User's Phone Number");
            int no = Convert.ToInt32(Console.ReadLine());
            foreach (var user in AllUsers)
            {
                if(no == user.phoneNumber)
                {
                    Console.WriteLine($"Why do you want to remove {user.Name}");
                    string reason = Console.ReadLine();
                    AllUsers.Remove(user);
                    Console.WriteLine($"{no} has been deleted from contacts");
                    Console.ReadKey();
                    Admin.adminOptions();
                }
            }
            Console.WriteLine("There is no User with this phone number.");
            Console.ReadKey();
            Admin.adminOptions();
        }

        public void getUser()
        {
            Console.Clear();
            Console.WriteLine("Enter Phone Number of User");
            int no = Convert.ToInt32(Console.ReadLine());
            foreach (var user in AllUsers)
            {
                if(user.phoneNumber == no)
                {
                    Console.WriteLine($"Name => {user.Name}");
                    Console.WriteLine($"Address => {user.Address}");
                    Console.WriteLine($"Phone Number => {user.phoneNumber}");
                    Console.ReadKey();
                    Admin.adminOptions();
                }
                
            }
            Console.WriteLine("There is no User with this phone number.");
            Console.ReadKey();
            Admin.adminOptions();
        }

        public void getAllUser()
        {
            Console.Clear();
            Console.WriteLine("========== All Users ==========");
            if (AllUsers.Count < 1)
            {
                Console.WriteLine("There is no User");
                Console.ReadKey();
                Admin.adminOptions();
                
            }
            else
            {
                foreach (var user in AllUsers)
                {
                    Console.WriteLine($"Name => {user.Name}");
                    Console.WriteLine($"Phone Number => {user.phoneNumber}");
                    Console.WriteLine($"Address => {user.Address}");
                }
                Console.ReadKey();
                Admin.adminOptions();
            }
            
        }

        public void userOptions()
        {
            Contacts contacts = new Contacts();
            Console.Clear();
            Console.WriteLine("========== User Options ==========");
            Console.WriteLine("1. View all Contacts");
            Console.WriteLine("2. Search for Contact");
            Console.WriteLine("3. Add Contacts");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Log Out");

            string option = Console.ReadLine();
            if(option == "1")
            {
                contacts.getAllContacts();
            }else if(option == "2")
            {
                contacts.getContact();
            }
            else if(option == "3")
            {
                contacts.AddContact();
            }
            else if(option == "4")
            {
                contacts.RemoveContact();
            }
            else if (option == "5")
            {
                Program.logOut();
            }
        }
    }

    

    
}
