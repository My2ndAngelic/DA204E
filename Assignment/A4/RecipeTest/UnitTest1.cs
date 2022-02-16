using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using NUnit.Framework;
using RecipeDNC;

namespace RecipeTest
{
    public class Tests
    {
        private readonly int size = new Recipe().MaxNumOfIngredients;

        private string[] Result()
        {
            List<string> result = new List<string>();
            for (int i = 0; i < size; i++)
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
            Recipe r = new Recipe();
            for (int i = 0; i < size; i++)
                r.AddIngredient2("ur mom");
            Assert.AreEqual(Result(), r.Ingredients);

        }
        
        [Test]
        public void AddIngredient1()
        {
            Recipe r = new Recipe();
            for (int i = 0; i < size; i++)
                r.AddIngredient("ur mom");
            Assert.AreEqual(Result(), r.Ingredients);
        }
    }
}