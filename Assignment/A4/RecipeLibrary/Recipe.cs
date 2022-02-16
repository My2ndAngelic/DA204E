using System;
using System.Text;

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
            this.ingredients = new string[MaxNumOfIngredients];
            this.name = string.Empty;
        }

        public Recipe(FoodCategory category, string description, string[] ingredients, string name)
        {
            this.category = category;
            this.description = description;
            this.ingredients = new string[MaxNumOfIngredients];
            if (ingredients.Length <= MaxNumOfIngredients)
            {
                Array.Copy(ingredients, this.ingredients, ingredients.Length);
            }
            else
            {
                throw new ArgumentException($@"Max ingredient: {MaxNumOfIngredients}");
            }
            this.name = name;
        }

        public bool AddIngredient2(string value)
        {
            int l = 0, r = ingredients.Length - 1;
            if (ingredients[l] == null)
            {
                ingredients[l] = value;
                return true;
            }

            if (ingredients[r] != null)
            {
                return false;
            }
            
            while (l <= r)
            {
                int m = (l + r) / 2;

                if (ingredients[m] == null)
                {
                    if (ingredients[m - 1] != null)
                    {
                        ingredients[m] = value;
                        return true;
                    }

                    r = m - 1;
                }
                else
                {
                    if (ingredients[m + 1] == null)
                    {
                        ingredients[m + 1] = value;
                        return true;
                    }

                    l = m + 1;
                }
            }

            return false;
        }
        
        public bool AddIngredient(string value)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i] == null)
                {
                    ingredients[i] = value;
                    return true;
                }
            }
            return false;
        }

        public bool ChangeIngredientAt(int index, string value)
        {
            if (index >= MaxNumOfIngredients || ingredients[index] == null)
            {
                return false;
            }

            ingredients[index] = value;
            return true;
        }
    }
}