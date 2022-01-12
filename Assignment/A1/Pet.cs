using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class Pet
    {
        /**
         * Private fields
         */
        private string name;    // pet name
        private int age;        // pet age
        private bool isFemale;  // pet gender (T: female, F: male)

        /** 
         * Pet main handler
         */
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

        /** 
         * Pet data handler
         */
        public void ReadAndSavePetData()
        {
            ReadAndSaveName();
            ReadAndSaveAge();
            ReadAndSaveIsFemale();
        }

        /** 
         * Pet name handler
         */
        private void ReadAndSaveName()
        {
            Console.Write("What is your pet name? ");
            name = Console.ReadLine();
        }

        /** 
         * Pet age handler
         */
        private void ReadAndSaveAge()
        {
            Console.Write("What is your pet age? ");
            age = int.Parse(Console.ReadLine()); // try parsing what user entered
        }

        /** 
         * Pet gender handler
         */
        private void ReadAndSaveIsFemale()
        {
            Console.Write("Is your pet female (Y/N)? ");
            char response = Console.ReadLine().Trim()[0];
            isFemale = response == 'y' || response == 'Y'; // Female if first character is Y/y, Male if otherwise
        }

        /** 
         * Pet data display
         */
        public void DisplayPetInfo()
        {
            string textOut = "Name: " + name + "; Age: " + age;                 // name and age export
            Console.WriteLine(textOut);
            textOut = name + " is a good " + (isFemale ? "girl" : "boy") + "!"; // gender export
            Console.WriteLine(textOut);
        }
    }
}
