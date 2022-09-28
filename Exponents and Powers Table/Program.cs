using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace Exponents_and_Powers_Table
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello! Today we will be learning your squares and cubes!");
            while (true)
            {
                
                Console.WriteLine("Enter an Integer ranging from 1-1290");
                int pickednumber = int.Parse(Console.ReadLine());

                if (pickednumber <= 0 || 1291 <= pickednumber)
                {
                    Console.WriteLine("You have chosen a number that can not be selected. Please pick another number.");
                    continue;
                }


                CalculateExponents(pickednumber);
                if (RunAgain()==false)
                {
                    break;
                }
            }
            
        }

        static void CalculateExponents(int chosenNumber)
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine($" {"Number", 10} {"Squared", 10} {"Cubed", 15}");
            for ( int i = 1; i <chosenNumber+1; i++)
            {
                int result = (int)Math.Pow(i, 2);
                int result2 = (int)Math.Pow(i, 3);
                Console.WriteLine($" {i, 10} {result,10} {result2,15}");
            }

        }


        static bool RunAgain()
        {
                Console.WriteLine("Would you like to choose another number? Y/N");
                string restart = Console.ReadLine().ToLower();
                if (restart == "y")
                {
                return true;
                }
                else if (restart == "n")
                {
                    // ends the program
                    Console.WriteLine(" Have a great day !");
                return false;
                }
                else
                {
                Console.WriteLine(" Im sorry, im not sure what that meant.");
                return RunAgain();
                }

        }
    }
}