using System;

namespace RecipeDNC
{
    public class Recipe
    {
        private FoodCategory category;
        private string description;
        private string[] ingredients;
        private string name;

        public FoodCategory Category
        {
            get => category;
            set => this.category = value;
        }

        public string Description
        {
            get => description;
            set => this.description = value;
        }

        public string[] Ingredients
        {
            get => ingredients;
            set => this.ingredients = value;
        }

        public string Name
        {
            get => name;
            set => this.name = value;
        }

        public int MaxNumOfIngredients
        {
            get => 50;
        }
        
        public Recipe()
        {
            this.category = FoodCategory.Fish;
            this.description = string.Empty;
            this.ingredients = new string[50];
            this.name = string.Empty;
        }

        public Recipe(FoodCategory category, string description, string[] ingredients, string name)
        {
            this.category = category;
            this.description = description;
            if (ingredients.Length <= 50)
            {
                this.ingredients = ingredients;
            }
            else
            {
                throw new ArgumentException("Max ingredient: 50");
            }
            this.name = name;
        }

        public bool AddIngredient(string value)
        {
            if (ingredients.Length < MaxNumOfIngredients)
            {
                
                return true;
            }

            return false;
        }
    }
}