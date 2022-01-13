using System;

namespace A1
{
    class Pet
    {
		/// <summary>
		/// 
		/// </summary>
		private string name;    // pet name
        private int age;        // pet age
        private bool isFemale;  // pet gender (T: female, F: male)

        /// <summary>
		/// 
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
		/// 
		/// </summary>
        public void ReadAndSavePetData()
        {
            ReadAndSaveName();
            ReadAndSaveAge();
            ReadAndSaveIsFemale();
        }

        /// <summary>
		/// 
		/// </summary>
        private void ReadAndSaveName()
        {
            Console.Write("What is your pet name? ");
            name = Console.ReadLine();
        }

        /// <summary>
		/// 
		/// </summary>
        private void ReadAndSaveAge()
        {
            Console.Write("What is " + name + "'s " + "age? ");
            age = int.Parse(Console.ReadLine()); // try parsing what user entered
        }

        /// <summary>
		/// Pet gender handler
		/// </summary>
        private void ReadAndSaveIsFemale()
        {
            Console.Write("Is your pet female (Y/N)? ");
            char response = Console.ReadLine().Trim()[0];
            isFemale = response == 'y' || response == 'Y'; // Female if first character is Y/y, Male if otherwise
        }

        /// <summary>
		/// Pet data display
		/// </summary>
        public void DisplayPetInfo()
        {
            string textOut = "Name: " + name + "; Age: " + age;                 // name and age export
            Console.WriteLine(textOut);
            textOut = name + " is a good " + (isFemale ? "girl" : "boy") + "!"; // gender export
            Console.WriteLine(textOut);
        }
    }
}
