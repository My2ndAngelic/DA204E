using System;
using System.Linq;

namespace RecipeLibrary
{
    public class Recipe
    {
        private readonly int maxNumOfIngredients;
        private FoodCategory category;
        private string description;
        private string[] ingredients;
        private string name;

        public Recipe()
        {
            category = FoodCategory.Fish;
            description = string.Empty;
            maxNumOfIngredients = 50;
            ingredients = new string[MaxNumOfIngredients];
            name = string.Empty;
        }

        public Recipe(int maxNumOfIngredients)
        {
            category = FoodCategory.Fish;
            description = string.Empty;
            this.maxNumOfIngredients = maxNumOfIngredients;
            ingredients = new string[MaxNumOfIngredients];
            name = string.Empty;
        }

        public Recipe(string name, FoodCategory category, string[] ingredients)
        {
            this.category = category;
            maxNumOfIngredients = 50;
            this.ingredients = new string[maxNumOfIngredients];
            if (ingredients.Length > maxNumOfIngredients)
                throw new ArgumentException($@"Max ingredient: {maxNumOfIngredients}");
            Array.Copy(ingredients, this.ingredients, ingredients.Length);
            this.name = name;
        }
        
         public Recipe(string name, FoodCategory category, string[] ingredients, string description, int maxNumOfIngredients)
        {
            this.name = name;
            this.category = category;
            this.ingredients = new string[maxNumOfIngredients];
            if (ingredients.Length > maxNumOfIngredients)
                throw new ArgumentException($@"Max ingredient: {maxNumOfIngredients}");
            Array.Copy(ingredients, this.ingredients, ingredients.Length);
            this.description = description;
        } 

        public FoodCategory Category
        {
            get => category;
            set => category = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string[] Ingredients
        {
            get
            {
                string[] result = new string[GetNumberOfIngredients()];
                for (int i = 0; i < result.Length; i++)
                {
                    result[i] = ingredients[i];
                }

                return result;
            }
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int MaxNumOfIngredients => maxNumOfIngredients;

        /// <summary>
        ///     Add ingredients with linear search
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool AddIngredientLinear(string value)
        {
            int vp = FindVacantPositionLinear();

            if (value == null || vp < 0) return false;

            ingredients[vp] = value;
            return true;
        }

        /// <summary>
        ///     Add ingredient with binary search
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool AddIngredientBinary(string value)
        {
            int vp = FindVacantPositionBinary();

            if (value == null || vp < 0) return false;

            ingredients[vp] = value;
            return true;
        }

        public bool ChangeIngredientAt(int index, string value)
        {
            if (index >= MaxNumOfIngredients || ingredients[index] == null || value == null) return false;
            ingredients[index] = value;
            return true;
        }

        private bool CheckIndex(int index)
        {
            return index >= 0 && index < maxNumOfIngredients && ingredients[index] != null;
        }

        public void DeleteIngredientAt(int index)
        {
            for (int i = index; i < maxNumOfIngredients - 1; i++) ingredients[i] = ingredients[i + 1];

            ingredients[maxNumOfIngredients] = null;
        }

        public int GetNumberOfIngredients()
        {
            int result = FindVacantPositionBinary();
            return result is not -69 ? result : maxNumOfIngredients;
        }

        public string GetIngredientAt(int index)
        {
            return CheckIndex(index) ? ingredients[index] : null;
        }

        public void DefaultValues()
        {
        }

        private int FindVacantPositionLinear()
        {
            for (int i = 0; i < maxNumOfIngredients; i++)
                if (ingredients[i] == null)
                    return i;

            return -69;
        }

        private int FindVacantPositionBinary()
        {
            int l = 0, r = ingredients.Length - 1;
            if (ingredients[l] == null) return l;

            if (ingredients[r] != null)
                return -69;

            while (l <= r)
            {
                int m = (l + r) / 2;

                if (ingredients[m] == null)
                {
                    if (ingredients[m - 1] != null) return m;

                    r = m - 1;
                }
                else
                {
                    if (ingredients[m + 1] == null) return m + 1;

                    l = m + 1;
                }
            }

            return -420;
        }

        public string GetIngredientString()
        {
            return $"{name, -50} {category, -20} {GetNumberOfIngredients(), -10}";
        }
        
        public override string ToString()
        {
            string ingredient = string.Empty;
            for (int i = 0; i < GetNumberOfIngredients(); i++)
            {
                ingredient += $"{ingredients[i]}, ";
            }

            ingredient = ingredient.Remove(ingredient.Length - 2, 2);
            ingredient += ".";
            return $"{ingredient}\n{description}";
        }
    }
}