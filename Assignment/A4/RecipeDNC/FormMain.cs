using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RecipeLibrary;
using System.Runtime.InteropServices;

namespace RecipeDNC
{
    public partial class FormMain : Form
    {
        private const int maxNumOfRecipe = 200;
        private const int maxNumOfIngredients = 50;
        private Recipe currRecipe = new Recipe(maxNumOfIngredients);
        private bool editMode;
        private RecipeManager rm = new RecipeManager(maxNumOfRecipe);

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        protected string editModeLMAO => editMode ? "Edit mode" : "Add mode";

        private void InitializeGUI()
        {
            InitializeGroupBox();

            listBoxRecipe.Font = new Font("Consolas", 9);
            textBoxName.MaxLength = 50;
            listBoxRecipe.SelectionMode = SelectionMode.MultiExtended;
            labelMode.Text = editModeLMAO;
            buttonAddIngredients.Text = @"Add ingredients";
            buttonAddRecipe.Text = @"Add recipe";
        }


        private void InitializeGroupBox()
        {
            comboBoxCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            comboBoxCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
        }

        private void testShit()
        {
            string[] s = new string[50];
            for (int i = 0; i < 50; i++) s[i] = $"Ur Mom {i}.";
            rm.Add(new Recipe("Ur Mom 1", FoodCategory.Fish, new[] {"ur mom"}, "Number 1"));
            rm.Add(new Recipe("Ur Mom 2", FoodCategory.Meat, s, "Number 2"));
            rm.Add(new Recipe("Ur Mom 3", FoodCategory.Pasta, s, "Number 3"));
            listBoxRecipe.DataSource = rm.GetRecipes();
        }

        private void buttonAddIngredients_Click(object sender, EventArgs e)
        {
            FormIngredients fi = new FormIngredients(currRecipe);
            DialogResult dlgResult = fi.ShowDialog();

            if (dlgResult == DialogResult.OK)
                currRecipe = fi.Recipe;
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            if (currRecipe.GetNumberOfIngredients() <= 0)
            {
                MessageBox.Show(@"No ingredient specified", @"Error");
                return;
            }

            if (editMode)
            {
                rm.ChangeRecipeAt(listBoxRecipe.SelectedIndex, new Recipe(
                    textBoxName.Text,
                    (FoodCategory) Enum.Parse(typeof(FoodCategory),
                        comboBoxCategory.SelectedValue.ToString() ?? string.Empty),
                    currRecipe.Ingredients,
                    textBoxDescription.Text,
                    maxNumOfIngredients));
                labelMode.Text = @"Recipe saved";
                listBoxRecipe.DataSource = rm.GetRecipes();
            }
            else
            {
                rm.Add(new Recipe(
                    textBoxName.Text,
                    (FoodCategory) Enum.Parse(typeof(FoodCategory),
                        comboBoxCategory.SelectedValue.ToString() ?? string.Empty),
                    currRecipe.Ingredients,
                    textBoxDescription.Text,
                    maxNumOfIngredients));
                currRecipe = new Recipe(maxNumOfIngredients);
                textBoxName.Text = string.Empty;
                textBoxDescription.Text = string.Empty;
                listBoxRecipe.DataSource = rm.GetRecipes();
            }
        }

        private void buttonEditBegin_Click(object sender, EventArgs e)
        {
            if (rm.GetNumberOfRecipes() <= 0) return;
            editMode = true;
            currRecipe = new Recipe(rm.GetRecipeAt(listBoxRecipe.SelectedIndices[0]));

            // GUI
            labelMode.Text = editModeLMAO;
            textBoxName.Text = currRecipe.Name;
            textBoxDescription.Text = currRecipe.Description;
            comboBoxCategory.SelectedItem = currRecipe.Category;
            buttonAddIngredients.Text = @"Edit ingredients";
            buttonAddRecipe.Text = @"Save recipe";
        }

        private void buttonEditFinish_Click(object sender, EventArgs e)
        {
            editMode = false;
            currRecipe = new Recipe(maxNumOfIngredients);

            // GUI
            labelMode.Text = editModeLMAO;
            buttonAddIngredients.Text = @"Add ingredients";
            buttonAddRecipe.Text = @"Add recipe";
            textBoxName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
            comboBoxCategory.SelectedIndex = 0;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRecipe.SelectedIndex != -1)
                for (int i = listBoxRecipe.SelectedItems.Count - 1; i >= 0; i--)
                    rm.RemoveAt(listBoxRecipe.SelectedIndices[i]);
            listBoxRecipe.DataSource = rm.GetRecipes();
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            rm = new RecipeManager();
            editMode = false;
            labelMode.Text = editModeLMAO;
            listBoxRecipe.DataSource = rm.GetRecipes();
        }

        private void listBoxRecipe_DoubleClick(object sender, EventArgs e)
        {
            Recipe r = rm.RecipeListToString(listBoxRecipe.SelectedIndex);
            MessageBox.Show("Ingredients\n" +
                            $"{string.Join(", ", r.Ingredients.Where(s => !string.IsNullOrEmpty(s)))}\n\n" +
                            "Description\n" +
                            $"{r.Description}",
                $@"{r.Name}");
        }

        private void listBoxRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!editMode) return;
            labelMode.Text = editModeLMAO;
            currRecipe = rm.RecipeListToString(listBoxRecipe.SelectedIndex);
            textBoxName.Text = currRecipe.Name;
            textBoxDescription.Text = currRecipe.Description;
            comboBoxCategory.SelectedItem = currRecipe.Category;
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            testShit();
        }
    }
}