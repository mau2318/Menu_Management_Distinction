using System;
namespace MenuManagement
{
    public class Authentication
    {
        private string _role;

        public Authentication()
        {
        }

        public void Identify()
        {
            Console.WriteLine("Hi mate.\nIf you are management, please press 1 \nIf you are customer, please press 2");
            _role = Console.ReadLine();
            if (_role == "1")
            {
                Console.WriteLine("You have the authority to modify the menu.");
            }
            else if (_role == "2")
            {
                Console.WriteLine("Here is our menu, you can browse it and order via this machine, feel free to call us if you have any questions");
            }
            else
            {
                Console.WriteLine("Please press 1 or 2");
            }
        }
    }
}
