using System;

namespace Assignment2
{
    public class SelectionAndIteration
    {
        /// <summary>
        ///     Constructor, launching 4 methods
        /// </summary>
        public SelectionAndIteration()
        {
            Start();
            ShowStringLength();
            Console.WriteLine();
            MakeMyDay();
            Console.WriteLine();
            SumNumbers();
        }

        /// <summary>
        ///     Start the class
        /// </summary>
        public void Start()
        {
            Console.WriteLine();
            Console.WriteLine("My name is Evan Huynh and I am a student of VT22 semester");
            Console.WriteLine();
        }

        /// <summary>
        ///     Calculate string length until user enter an empty string
        /// </summary>
        private void ShowStringLength()
        {
            Console.WriteLine("Let me calculate the string length for you.");
            bool done = false;
            do
            {
                Console.WriteLine("Give me a text of any length or press Enter to exit.");
                string userInput = Console.ReadLine();
                Console.WriteLine(!userInput.Equals(string.Empty)
                    ? $"{Environment.NewLine}{userInput.ToUpper()}{Environment.NewLine}"
                      + $"Number of chars = {userInput.Length}{Environment.NewLine}"
                    : "OK. You pressed Enter. See you again!");
                if (userInput.Length == 0) done = true;
            } while (!done);
        }

        /// <summary>
        ///     Ask user a number and the turn the mood of the day
        /// </summary>
        private void MakeMyDay()
        {
            Console.WriteLine("Let me predict the day for you.");
            Console.Write("Give a number between 1 and 7: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday: Keep calm! You can fall apart!");
                    break;
                case 2:
                    Console.WriteLine("Tuesday and Wednesday break your heart!");
                    break;
                case 3:
                    Console.WriteLine("Tuesday and Wednesday break your heart!");
                    break;
                case 4:
                    Console.WriteLine("Thursday, Uuush, still one day to Friday!");
                    break;
                case 5:
                    Console.WriteLine("It's Friday! You are in love!");
                    break;
                case 6:
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case 7:
                    Console.WriteLine("And Sunday always comes too soon!");
                    break;
                default:
                    Console.WriteLine("Not in a good mode? This is not a valid date!");
                    break;
            }
        }

        /// <summary>
        ///     Calculate the arithmetic from start to finish, d = 1
        /// </summary>
        private void SumNumbers()
        {
            Console.Write("Give start number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Give end number: ");
            int end = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = start < end ? start : end; i <= (start < end ? end : start); i++)
                sum += i; // In case start < end, no need to switch them, just assign correct value to for loop


            Console.WriteLine(
                $@"The sum between {(start < end ? start : end)} and {(start < end ? end : start)} is: {sum}");
        }
    }
}