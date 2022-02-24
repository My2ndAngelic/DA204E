using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using NUnit.Framework;
using RecipeLibrary;

namespace RecipeNUnit
{
    public class Tests
    {
        private readonly int ingredientSize = 1000000;
        private readonly int recipeSize = new RecipeManager().MaxNumOfRecipe;

        private string[] Result()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < ingredientSize; i++)
                result.Add("ur mom");
            return result.ToArray();
        }

        
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void AddIngredient2()
        {
            Recipe r = new Recipe(ingredientSize);
            for (int i = 0; i < ingredientSize+100; i++)
                r.AddIngredientBinary("ur mom");
            Assert.AreEqual(Result(), r.Ingredients);

        }
        
        [Test]
        public void AddIngredient1()
        {
            Recipe r = new Recipe(ingredientSize);
            for (int i = 0; i < ingredientSize; i++)
                r.AddIngredientLinear("ur mom");
            Assert.AreEqual(Result(), r.Ingredients);
        }

        [Test]
        public void DeleteIngredient()
        {
            Recipe r = new Recipe();
            for (int i = 0; i < ingredientSize; i++)
                r.AddIngredientLinear("ur mom");
        }
    }
}