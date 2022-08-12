using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Menu
    {
        public string CallMenu()
        {
            string menu = "x";
            while (menu != "1" && menu != "2" && menu != "3")
            {
                Console.WriteLine("What you wanna do?");
                Console.WriteLine("1 - Add a grade");
                Console.WriteLine("2 - Get statistics");
                Console.WriteLine("3 - Quit");
                menu = Console.ReadLine();

                if(menu != "1" && menu != "2" && menu != "3")
                {
                    Console.WriteLine("Invalid value entered, please retry");
                }

            }

            return menu;
        }
    }
}
