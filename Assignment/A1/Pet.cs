using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1
{
    class Pet
    {
        // Private fields
        private string name;    // pet name
        private int age;        // pet age
        private bool isFemale;  // pet gender (T: female, F: male)

        // Main pet owner program
        public void Start() 
        {
            Console.WriteLine("Pet Owner");
            ReadAndSavePetData();
            Console.WriteLine();
            Console.WriteLine("--------------");
            DisplayPetInfo();
            Console.WriteLine("--------------");
            Console.WriteLine();
        }

        // Pet data handler
        public void ReadAndSavePetData()
        {
            ReadAndSaveName();
            ReadAndSaveAge();
            ReadAndSaveIsFemale();
        }

        private void ReadAndSaveName()
        {
            Console.Write("What is your pet name? ");
            name = Console.ReadLine();
        }

        private void ReadAndSaveAge()
        {
            Console.Write("What is your pet age? ");
            age = int.Parse(Console.ReadLine());
        }

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
            string textOut = "Name: " + name + "; Age: " + age;
            Console.WriteLine(textOut);
            textOut = name + " is a good " + (isFemale ? "girl" : "boy") + "!";
            Console.WriteLine(textOut);
        }
    }
}
