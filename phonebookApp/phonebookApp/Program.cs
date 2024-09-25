using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebookApp
{
    static internal class Program
    {

        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Welcome To the most recent phone book app");
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            string option1 = Console.ReadLine();

            if(option1 == "1")
            {
                Console.WriteLine("Enter Admin Password");
                string passWord = Console.ReadLine();
                if(passWord == "1") 
                {
                    Console.WriteLine("Welcome Admin");
                    Admin.adminOptions();
                }
            }
            else if(option1 == "2")
            {
                Console.WriteLine("1. Sign in");
                Console.WriteLine("2. Login");
                string option = Console.ReadLine();

                if(option == "2")
                {
                    user.login();
                }
                else if (option == "1")
                {
                    user.signUp();

                }
            
            }
        }

        static public void logOut()
        {
            Console.Clear();
            Main(null);
        }

        
    }
}
