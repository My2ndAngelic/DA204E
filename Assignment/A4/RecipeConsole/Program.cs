using System;
using System.Diagnostics;
using RecipeDNC;

namespace RecipeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Stopwatch sw = new Stopwatch();
            Recipe recipe = new Recipe();
            
            Console.WriteLine("-------2------");
            Recipe recipe2 = new Recipe();
            for (int i = 0; i < 50; i++)
            {
                sw.Start();
                recipe2.AddIngredient2($@"ur mom {i}");
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
            
            Console.WriteLine("-------1------");
            for (int i = 0; i < 50; i++)
            {
                sw.Start();
                recipe.AddIngredient2($@"ur mom {i}");
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
            
            
        }
    }
}