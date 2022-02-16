using System;
using Microsoft.CSharp.RuntimeBinder;

namespace RecipeDNC
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
            maxNumOfIngredients = 50000;
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

        public Recipe(FoodCategory category, string description,  int maxNumOfIngredients, string[] ingredients, string name)
        {
            this.category = category;
            this.description = description;
            this.ingredients = new string[maxNumOfIngredients];
            if (ingredients.Length <= maxNumOfIngredients)
                Array.Copy(ingredients, this.ingredients, ingredients.Length);
            else
                throw new ArgumentException($@"Max ingredient: {maxNumOfIngredients}");
            this.name = name;
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
            get => ingredients;
            set => ingredients = value;
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
        public bool AddIngredient(string value)
        {
            for (int i = 0; i < ingredients.Length; i++)
                if (ingredients[i] == null)
                {
                    ingredients[i] = value;
                    return true;
                }

            return false;
        }

        /// <summary>
        ///     Add ingredient with binary search
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool AddIngredient2(string value)
        {
            if (value == null)
            {
                return false;
            }

            int vp = FindVacantPosition();
            if (vp == -1)
            {
                return false;
            }

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
            return index < MaxNumOfIngredients && ingredients[index] != null;
        }

        public void DeleteIngredientAt(int index)
        {
            for (int i = index; i < MaxNumOfIngredients; i++) ingredients[i] = ingredients[i + 1];

            ingredients[MaxNumOfIngredients] = null;
        }

        public int CheckNumberOfIngredients()
        {
            return FindVacantPosition() != -69 ? FindVacantPosition() : maxNumOfIngredients;
        }

        public void DefaultValues()
        {
            
        }

        private int FindVacantPosition()
        {
            int l = 0, r = maxNumOfIngredients - 1;
            if (ingredients[l] == null)
            {
                return l;
            }

            if (ingredients[r] != null) return -69;

            while (l <= r)
            {
                int m = (l + r) / 2;

                if (ingredients[m] == null)
                {
                    if (ingredients[m - 1] != null)
                    {
                        return m;
                    }

                    r = m - 1;
                }
                else
                {
                    if (ingredients[m + 1] == null)
                    {
                        return m + 1;
                    }

                    l = m + 1;
                }
            }

            return -420;
        }
        
        public void AUrMom()
        {
            Console.WriteLine("Ur mom");
        }
    }
}