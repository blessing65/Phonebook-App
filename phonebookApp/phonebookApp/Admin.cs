using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebookApp
{
    static internal class Admin
    {
        static public void adminOptions()
        {
            Console.Clear();
            Console.WriteLine("========== Admin Options ==========");
            Console.WriteLine("1. View all User");
            Console.WriteLine("2. Search for User");
            Console.WriteLine("3. Delete User");
            Console.WriteLine("4. Log Out");

            User user = new User();

            string option = Console.ReadLine();
            if (option == "1")
            {
                user.getAllUser();
            }
            else if (option == "2")
            {
                user.getUser();
            }
            else if (option == "3")
            {
                user.removeUser();
            }
            else if (option == "4")
            {
                Program.logOut();
            }
        }
    }
}


