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

            int retireAge;
            if (userAge % 2 == 0)
            {
                retireAge = 18;
            }
            else
            {
                retireAge = 25;
            }

            //user siblings and vacation home
            string location;
            if (userSibling == 0)
            {
                location = "Las Vegas";
            }
            else if (userSibling == 1)
            {
                location = "Los Angeles";
            }
            else if (userSibling == 2)
            {
                location = "Dubai ";
            }
            else if (userSibling == 3)
            {
                location = "Miami";
            }
            else if (userSibling > 3)
            {
                location = "Dubai";
            }
            else
            {
                location = "North Korea";
            }

            //Mode of transportation based on favorite color

            string modeOfTransportation = "";

                if (lowerColor == "red" )
            {
                modeOfTransportation = "car";
            }
                else if (lowerColor == "orange")
            {
                modeOfTransportation = "boat";
            }
                else if (lowerColor == "yellow")
            {
                modeOfTransportation = "plane";
            }
                else if (lowerColor == "green")
            {
                modeOfTransportation = "segway";
            }
                else if (lowerColor == "blue")
            {
                modeOfTransportation = "motorcycle";
            }
                else if (lowerColor == "indigo")
            {
                modeOfTransportation = "bicycle";
            }
                else if (lowerColor == "violet")
            {
                modeOfTransportation = "skateboard";
            }

            //How much money in the bank the user has

            string bankAccount;
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankAccount = "$5,000";
            }
                else if (birthMonth >= 5 && birthMonth <=8)
            {
                bankAccount = "$10,000";
            }
                else if (birthMonth >= 9 && birthMonth <=19)
            {
                bankAccount = "$20,000";
            }
                else
            {
                bankAccount = "You are broke";
            }

            //Part 3 -The Users Fortune

            Console.WriteLine(nameFirst + " " + nameLast + " will retire in " + retireAge + " with " + bankAccount +
                " in the bank, a vaction home in " + location + " and a " + modeOfTransportation);
                
                


        }
    }
}
