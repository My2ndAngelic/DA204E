using System;
using System.Diagnostics;
using RecipeLibrary;

namespace RecipeConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] s = new string[50];
            for (int i = 0; i < 50; i++) s[i] = $"Ur Mom {i}.";
            RecipeManager rm = new RecipeManager(200);
            rm.Add(new Recipe("Ur Mom 1", FoodCategory.Fish, new string[]{"ur mom"}, "Number 1"));
            rm.Add(new Recipe("Ur Mom 2", FoodCategory.Meat, s, "Number 2"));
            rm.Add(new Recipe("Ur Mom 3", FoodCategory.Pasta, s, "Number 3"));
            
        }
    }
}