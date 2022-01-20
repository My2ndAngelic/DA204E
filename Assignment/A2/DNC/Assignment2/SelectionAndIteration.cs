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
            Start();
        }

        public void Start()
        {
        }

        /// <summary>
        /// </summary>
        private void ShowStringLength()
        {
            Console.WriteLine("Let me calculate the string length for you.");
            var userInput = "";
            do
            {
                Console.WriteLine(userInput.ToUpper() +
                                  (!userInput.Equals("")
                                      ? "\nNumber of chars = " + userInput.Length
                                      : ""));
                Console.WriteLine("Give me a text of any length or press Enter to exit.");
                userInput = Console.ReadLine();
                Console.WriteLine();
            } while (!userInput.Equals(""));
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