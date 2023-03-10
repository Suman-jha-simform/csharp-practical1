using System;

namespace CalculatorApplication
{

    public class Calculator
    {

        public static void Main()
        {
            string userChoice = string.Empty; 

            do
            {

                double userNumber1;
                double userNumber2;
                                                                                            // Taking user input 
                Console.Write("\nNumber 1 : ");
                bool isintNumber1 = double.TryParse(Console.ReadLine(), out userNumber1);
                Console.Write("Number 2 : ");
                bool isintNumber2 = double.TryParse(Console.ReadLine(), out userNumber2);

                if (isintNumber1 && isintNumber2)                                          // checking if user input is valid
                {
                    Console.WriteLine("\nAddition of Number is : {0}", userNumber1 + userNumber2);
                    Console.WriteLine("Subtraction of Number is : {0}", userNumber1 - userNumber2);
                    Console.WriteLine("Multiplication of Number is : {0}", userNumber1 * userNumber2);
                    Console.WriteLine("Division of Number is : {0}", userNumber1 / userNumber2);
                }
                else if (!isintNumber1 || !isintNumber2)
                {
                    Console.WriteLine("\nPlease enter number only !!");
                }

                do
                {
                    Console.Write("\nDo you want to continue : Yes or No : ");
                    userChoice = Console.ReadLine()!;
                    if(userChoice.ToLower() != "yes" && userChoice.ToLower() != "no")
                    {
                        Console.WriteLine("please enter a valid choice !!! ");
                    }
                } while (userChoice.ToLower() != "yes" && userChoice.ToLower() != "no");         // loop until user enters a valid choice

            } while (userChoice.ToLower() == "yes");        // if userchoice is yes continue otherwise exit


        }
    }

}