using System;

namespace RecipeLibrary
{
    public class Recipe
    {
        private readonly int maxNumOfIngredients = 50;
        private FoodCategory category;
        private string description;
        private string[] ingredients;
        private string name;

        /// <summary>
        ///     Default constructor
        /// </summary>
        public Recipe()
        {
            category = FoodCategory.Fish;
            description = string.Empty;
            maxNumOfIngredients = 50;
            ingredients = new string[MaxNumOfIngredients];
            name = string.Empty;
        }

        /// <summary>
        ///     Constructor with max number of ingredients
        /// </summary>
        /// <param name="maxNumOfIngredients">Maximum number of ingredients</param>
        public Recipe(int maxNumOfIngredients)
        {
            category = FoodCategory.Fish;
            description = string.Empty;
            this.maxNumOfIngredients = maxNumOfIngredients;
            ingredients = new string[MaxNumOfIngredients];
            name = string.Empty;
        }

        /// <summary>
        ///     Constructor with name, category and ingredients list
        /// </summary>
        /// <param name="name">Name of the recipe</param>
        /// <param name="category">Category of the recipe</param>
        /// <param name="ingredients">List of ingredients of the recipe</param>
        public Recipe(string name, FoodCategory category, string[] ingredients)
        {
            this.name = name;
            this.category = category;
            this.ingredients = new string[maxNumOfIngredients];
            if (ingredients.Length > maxNumOfIngredients) return;

            Array.Copy(ingredients, this.ingredients, ingredients.Length);
        }

        /// <summary>
        ///     Constructor for all parameters except max number of ingredients = 50
        /// </summary>
        /// <param name="name">Name of the recipe</param>
        /// <param name="category">Category of the recipe</param>
        /// <param name="ingredients">List of ingredients of the recipe</param>
        /// <param name="description">Description of the recipe</param>
        public Recipe(string name, FoodCategory category, string[] ingredients, string description)
        {
            this.name = name;
            this.category = category;
            this.ingredients = new string[maxNumOfIngredients];
            this.description = description;
            if (ingredients.Length > maxNumOfIngredients) return;

            Array.Copy(ingredients, this.ingredients, ingredients.Length);
        }

        /// <summary>
        ///     Constructor for all fields
        /// </summary>
        /// <param name="name">Name of the recipe</param>
        /// <param name="category">Category of the recipe</param>
        /// <param name="ingredients">List of ingredients of the recipe</param>
        /// <param name="description">Description of the recipe</param>
        /// <param name="maxNumOfIngredients">Maximum number of allowed ingredients</param>
        public Recipe(string name, FoodCategory category, string[] ingredients, string description,
            int maxNumOfIngredients)
        {
            this.name = name;
            this.category = category;
            this.ingredients = new string[maxNumOfIngredients];
            if (ingredients.Length > maxNumOfIngredients) return;

            Array.Copy(ingredients, this.ingredients, ingredients.Length);
            this.description = description;
        }

        /// <summary>
        ///     Constructor for Recipe object
        /// </summary>
        /// <param name="recipe">Recipe object</param>
        public Recipe(Recipe recipe)
        {
            name = recipe.name;
            category = recipe.category;
            ingredients = recipe.ingredients;
            description = recipe.description;
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
        ///     Add ingredient with binary search
        /// </summary>
        /// <param name="value">Description of the ingredient</param>
        /// <returns>True if successfully added</returns>
        public bool AddIngredientBinary(string value)
        {
            int vp = FindVacantPositionBinary();

            if (value == null || vp < 0) return false;

            ingredients[vp] = value;
            return true;
        }

        /// <summary>
        ///     Change ingredient at position in the array
        /// </summary>
        /// <param name="index">Index of the element</param>
        /// <param name="value">Name of the ingredients</param>
        /// <returns>True if successfully changed</returns>
        public bool ChangeIngredientAt(int index, string value)
        {
            if (index >= MaxNumOfIngredients || ingredients[index] == null || value == null) return false;

            ingredients[index] = value;
            return true;
        }

        /// <summary>
        ///     Check if index in the ingredients array is not null
        /// </summary>
        /// <param name="index">Position in the array</param>
        /// <returns>True if not null</returns>
        private bool CheckIndex(int index)
        {
            return index >= 0 && index < maxNumOfIngredients && ingredients[index] != null;
        }

        /// <summary>
        ///     Null the element at index and move it to the final position
        /// </summary>
        /// <param name="index">Position in the array</param>
        public void DeleteIngredientAt(int index)
        {
            if (!CheckIndex(index)) return;

            for (int i = index; i < maxNumOfIngredients - 1; i++) ingredients[i] = ingredients[i + 1];

            ingredients[maxNumOfIngredients] = null;
        }

        /// <summary>
        ///     Get the number of existing existing ingredients
        /// </summary>
        /// <returns>Current number of ingredients</returns>
        public int GetNumberOfIngredients()
        {
            int result = FindVacantPositionBinary();
            return result is not -1 ? result : maxNumOfIngredients;
        }

        /// <summary>
        ///     Get the ingredient at index
        /// </summary>
        /// <param name="index">Position in the array</param>
        /// <returns>Ingredient description</returns>
        public string GetIngredientAt(int index)
        {
            return CheckIndex(index) ? ingredients[index] : null;
        }

        /// <summary>
        ///     Find the first null position in the array using binary search
        /// </summary>
        /// <returns>First non-null position in the array, -1 if not exist, -2 if something failed</returns>
        private int FindVacantPositionBinary()
        {
            int l = 0, r = ingredients.Length - 1; // covering whole array
            if (ingredients[l] == null) // left null, array is empty
                return l;

            if (ingredients[r] != null) // right not null, array full
                return -1;

            while (l <= r) // while the left is less than right
            {
                int m = (l + r) / 2; // take the mid

                if (ingredients[m] == null) // if mid null
                {
                    if (ingredients[m - 1] != null) // left isn't null => first non-empty element
                        return m;

                    r = m - 1; // if not then all right half is null => move the right cursor to mid - 1
                }
                else // mid is not null
                {
                    if (ingredients[m + 1] == null) // if right of mid is null => first empty element
                        return m + 1;

                    l = m + 1; // left half is not null => move the left cursor to mid + 1
                }
            }

            return -2; // something is wrong
        }

        /// <summary>
        ///     Return the short description of recipe
        /// </summary>
        /// <returns>Short description of recipe</returns>
        public string GetIngredientString()
        {
            return $"{name,-50} {category,-20} {GetNumberOfIngredients(),3}";
        }

        /// <summary>
        ///     Return recipe string with ingredients and description
        /// </summary>
        /// <returns>Recipe string with ingredients and description</returns>
        public override string ToString()
        {
            string ingredient = string.Empty;
            for (int i = 0; i < GetNumberOfIngredients(); i++) ingredient += $"{ingredients[i]}, ";

            ingredient = ingredient.Remove(ingredient.Length - 2, 2);
            // ingredient += ".";
            return $"Ingredients\n{ingredient}\n\nDescription\n{description}";
        }
    }
}
