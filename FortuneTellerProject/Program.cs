using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTellerProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //PART ONE: asking user for personal information

            Console.WriteLine("What is your first name?");
            string nameFirst = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string nameLast = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("What month were you born in? Please state the number of the month");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your favorite ROYGBIV color? If you do not know what ROYGBIV is please type Help");
            string userColor = Console.ReadLine();
            string lowerColor = userColor.ToLower();
            if (lowerColor == "help")
            {
                Console.WriteLine("the colors are red, oragne, yellow, green, blue, indigo and violet");
                Console.WriteLine("Out of the choices, please insert your favorite");
                userColor = Console.ReadLine();
            }
            Console.WriteLine("How many siblings do you have?");
            int userSibling = int.Parse(Console.ReadLine());

            //PART TWO:
            //user age is either even or odd

            Console.WriteLine("please re-insert your age");
            int userNewAge = int.Parse(Console.ReadLine());
            int retireAge; 
            if (userNewAge % 2 == 0)
            {
                retireAge = 18;
            }
            else
            {
                retireAge = 25;
            }


        }
    }
}
