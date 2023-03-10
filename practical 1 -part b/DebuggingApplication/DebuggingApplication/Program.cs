using System;
using System.Diagnostics;

namespace DebuggingApplication
{
    public class DebuggingApplication
    {
        public  void Debug()
        {

            string userResponse = Console.ReadLine();

            if (Convert.ToBoolean(int.Parse(userResponse)))
            {

                Console.WriteLine("The entered value is a integer");

            }

        }

        public static void Main(string[] args)
        {
            DebuggingApplication debug = new();
            debug.Debug();
        }

    }
}
