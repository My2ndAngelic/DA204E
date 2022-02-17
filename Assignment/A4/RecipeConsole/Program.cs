using System;
using System.Diagnostics;
using RecipeLibrary;

namespace RecipeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stopwatch sw = new Stopwatch();
            Recipe recipe = new Recipe();

            for (int i = 0; i < 50; i++)
            {
                recipe.AddIngredient2($@"ur mom {i}");
                Console.WriteLine(recipe.GetNumberOfIngredients());
            }
            Console.WriteLine(Math.Round(69.420, 0));
        }
    }
}