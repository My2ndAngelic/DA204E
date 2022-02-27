namespace RecipeLibrary
{
    public class RecipeManager
    {
        private const int maxNumOfRecipe = 200;
        private readonly Recipe[] recipes;

        public RecipeManager()
        {
            recipes = new Recipe[maxNumOfRecipe];
        }

        public RecipeManager(int maxNumOfRecipe)
        {
            recipes = new Recipe[maxNumOfRecipe];
        }

        public int MaxNumOfRecipe => maxNumOfRecipe;

        public bool Add(Recipe recipe)
        {
            int vp = FindVacantPositionBinary();

            if (recipe == null || vp < 0) return false;

            recipes[vp] = recipe;
            return true;
        }

        public bool Add(string name, FoodCategory category, string[] ingredients)
        {
            int vp = FindVacantPositionBinary();
            if (vp < 0) return false;
            recipes[vp] = new Recipe(name, category, ingredients);
            return true;
        }

        public bool ChangeRecipeAt(int index, Recipe recipe)
        {
            if (index >= maxNumOfRecipe || recipes[index] == null) return false;
            recipes[index] = recipe;
            return true;
        }

        private bool CheckIndex(int index)
        {
            return index >= 0 && index < maxNumOfRecipe && recipes[index] != null;
        }

        public void RemoveAt(int index)
        {
            if (!CheckIndex(index)) return;
            for (int i = index; i < maxNumOfRecipe - 1; i++) recipes[i] = recipes[i + 1];

            recipes[maxNumOfRecipe - 1] = null;
        }

        public int GetNumberOfRecipes()
        {
            int result = FindVacantPositionBinary();
            return result is not -69 ? result : maxNumOfRecipe;
        }

        public string[] GetRecipes()
        {
            int temp = GetNumberOfRecipes();
            string[] result = new string[temp];
            for (int i = 0; i < temp; i++) result[i] = recipes[i].GetIngredientString();
            return result;
        }

        public Recipe GetRecipeAt(int index)
        {
            return recipes[index];
        }

        public Recipe RecipeListToString(int index)
        {
            return CheckIndex(index) ? recipes[index] : null;
        }

        private int FindVacantPositionBinary()
        {
            int l = 0, r = recipes.Length - 1;
            if (recipes[l] == null) return l;

            if (recipes[r] != null)
                return -69;

            while (l <= r)
            {
                int m = (l + r) / 2;

                if (recipes[m] == null)
                {
                    if (recipes[m - 1] != null) return m;

                    r = m - 1;
                }
                else
                {
                    if (recipes[m + 1] == null) return m + 1;

                    l = m + 1;
                }
            }

            return -420;
        }
    }
}