using System;

namespace Assignment2
{
    internal class SelectionAndIteration
    {
        /// <summary>
        /// </summary>
        public SelectionAndIteration()
        {
            Console.Clear();
            ShowStringLength();
        }

        /// <summary>
        /// </summary>
        private void ShowStringLength()
        {
            Console.WriteLine("Let me calculate the string length for you.");
            bool done = false;
            do
            {
                Console.WriteLine("Give me a text of any length or press Enter to exit.");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine(!userInput.Equals("")
                    ? userInput.ToUpper() + "\nNumber of chars = " + userInput.Length
                    : string.Empty);
                Console.WriteLine();
                if (userInput.Length == 0)
                {
                    done = true;
                }
            } while (!done);
        }

        /// <summary>
        /// </summary>
        private void MakeMyDay()
        {
            Console.WriteLine("");
        }

        /// <summary>
        /// </summary>
        private void SumNumbers()
        {
        }
    }
}