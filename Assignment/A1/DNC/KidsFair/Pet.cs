using System;

namespace KidsFair
{
    public class Pet
    {
        private int age; // pet age
        private bool isFemale; // pet gender (T: female, F: male)

        /// <summary>
        /// </summary>
        private string name; // pet name

        /// <summary>
        ///     Main method of pet
        /// </summary>
        public void Start()
        {
            Console.WriteLine("Pet Owner");
            ReadAndSavePetData();
            Console.WriteLine();
            Console.WriteLine("++++++++++++++");
            DisplayPetInfo();
            Console.WriteLine("++++++++++++++");
            Console.WriteLine();
        }

        /// <summary>
        ///     Pet data handler
        /// </summary>
        private void ReadAndSavePetData()
        {
            ReadAndSaveName();
            ReadAndSaveAge();
            ReadAndSaveIsFemale();
        }

        /// <summary>
        ///     This methods asks user name and save it to the field
        /// </summary>
        private void ReadAndSaveName()
        {
            Console.Write("What is your pet name? ");
            name = Console.ReadLine();
        }

        /// <summary>
        ///     This methods asks user age and save it to the field
        /// </summary>
        private void ReadAndSaveAge()
        {
            Console.Write("What is " + name + "'s " + "age? ");
            age = int.Parse(Console.ReadLine()); // try parsing what user entered
        }

        /// <summary>
        ///     This methods asks user if pet is female and save it to the field
        /// </summary>
        private void ReadAndSaveIsFemale()
        {
            Console.Write("Is your pet female (Y/N)? ");
            var response = Console.ReadLine().Trim()[0];
            isFemale = response == 'y' || response == 'Y'; // Female if first character is Y/y, Male if otherwise
        }

        /// <summary>
        ///     Display pet data to the user
        /// </summary>
        private void DisplayPetInfo()
        {
            var textOut = "Name: " + name + "; Age: " + age; // name and age export
            Console.WriteLine(textOut);
            textOut = name + " is a good " + (isFemale ? "girl" : "boy") + "!"; // gender export
            Console.WriteLine(textOut);
        }
    }
}