using System;

namespace Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a pin number between 4-8 digits");
            var pinNumber = Console.ReadLine();

            int number;
            bool success = Int32.TryParse(pinNumber, out number);

            if (success && pinNumber.Length <= 8 && pinNumber.Length >= 4)
            {
                Console.WriteLine($"Congrats, your pin number is {pinNumber}");
            }
            else if (success && pinNumber.Length > 8 || pinNumber.Length < 4)
            {
                Console.WriteLine($"Your pin number was {pinNumber.Length} digits long. Please try again.");
            }
            else
            {
                Console.WriteLine("What are you doing, dummy? That wasn't a number!");
            }

            //Console.WriteLine("please enter a valid 10-digit phone number. You may use dashes, parentheses, or spaces");
            //var phoneNumber = Console.ReadLine();

            //int phoneNum;
            //bool validPhone = Int32.TryParse(phoneNumber, out phoneNum);

            //if 
        }
    }
}
