namespace RecipeLibrary
{
    public class RecipeManager
    {
        private const int maxNumOfRecipe = 200;
        private readonly Recipe[] recipes;


        /// <summary>
        ///     Zero parameter constructor
        /// </summary>
        public RecipeManager()
        {
            recipes = new Recipe[maxNumOfRecipe];
        }

        /// <summary>
        ///     Constructor with max number of recipe
        /// </summary>
        /// <param name="maxNumOfRecipe"></param>
        public RecipeManager(int maxNumOfRecipe)
        {
            recipes = new Recipe[maxNumOfRecipe];
        }

        public int MaxNumOfRecipe => maxNumOfRecipe;

        /// <summary>
        ///     Add recipe object into the manager
        /// </summary>
        /// <param name="recipe">Recipe object</param>
        /// <returns>True if success</returns>
        public bool Add(Recipe recipe)
        {
            int vp = FindVacantPositionBinary();

            if (recipe == null || vp < 0)
            {
                return false;
            }

            recipes[vp] = recipe;
            return true;
        }


        /// <summary>
        ///     Change recipe at the index
        /// </summary>
        /// <param name="index">Index in the list of recipes</param>
        /// <param name="recipe">Recipe needed to be added</param>
        /// <returns>True if change successfully</returns>
        public bool ChangeRecipeAt(int index, Recipe recipe)
        {
            if (index >= maxNumOfRecipe || recipes[index] == null)
            {
                return false;
            }

            recipes[index] = recipe;
            return true;
        }

        /// <summary>
        ///     Check if index is valid and not null
        /// </summary>
        /// <param name="index">Index needed be check</param>
        /// <returns>True if succeeded</returns>
        private bool CheckIndex(int index)
        {
            return index is >= 0 and < maxNumOfRecipe && recipes[index] != null;
        }

        /// <summary>
        ///     Remove recipe at index method
        /// </summary>
        /// <param name="index">Recipe needed to be removed</param>
        public void RemoveAt(int index)
        {
            if (!CheckIndex(index))
            {
                return;
            }

            for (int i = index; i < maxNumOfRecipe - 1; i++)
            {
                recipes[i] = recipes[i + 1];
            }

            recipes[maxNumOfRecipe - 1] = null;
        }

        /// <summary>
        ///     Return current number of recipes
        /// </summary>
        /// <returns>Number of recipes</returns>
        public int GetNumberOfRecipes()
        {
            int result = FindVacantPositionBinary();
            return result is not -69 ? result : maxNumOfRecipe;
        }

        /// <summary>
        ///     Return array of recipes
        /// </summary>
        /// <returns>Array of recipes</returns>
        public string[] GetRecipes()
        {
            int temp = GetNumberOfRecipes();
            string[] result = new string[temp];
            for (int i = 0; i < temp; i++)
            {
                result[i] = recipes[i].GetIngredientString();
            }

            return result;
        }

        /// <summary>
        ///     Return the recipe at index
        /// </summary>
        /// <param name="index">Index needed to be return</param>
        /// <returns>Recipe at that index if valid, null if not exist</returns>
        public Recipe GetRecipeAt(int index)
        {
            return !CheckIndex(index) ? null : recipes[index];
        }

        /// <summary>
        ///     Return the first non-null location in the recipe array
        /// </summary>
        /// <returns>Index of first non-null location in the recipe array, -1 if not exist, -2 if error</returns>
        private int FindVacantPositionBinary()
        {
            int l = 0, r = recipes.Length - 1;
            if (recipes[l] == null)
            {
                return l;
            }

            if (recipes[r] != null)
            {
                return -1;
            }

            while (l <= r)
            {
                int m = (l + r) / 2;

                if (recipes[m] == null)
                {
                    if (recipes[m - 1] != null)
                    {
                        return m;
                    }

                    r = m - 1;
                }
                else
                {
                    if (recipes[m + 1] == null)
                    {
                        return m + 1;
                    }

                    l = m + 1;
                }
            }

            return -2;
        }
    }
}