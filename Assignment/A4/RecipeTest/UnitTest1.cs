using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;
using NUnit.Framework;
using RecipeDNC;

namespace RecipeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Recipe r1 = new Recipe();
            for (int i = 0; i < 100000; i++)
                r1.AddIngredient2("ur mom");
        }

        [Test]
        public void Test2()
        {
            Recipe r2 = new Recipe();
            for (int i = 0; i < 100000; i++)
                r2.AddIngredient("ur mom");
        }
    }
}