using System;
using System.Drawing;
using System.Windows.Forms;
using RecipeLibrary;

namespace RecipeDNC
{
    public partial class FormMain : Form
    {
        private static readonly int maxNumOfRecipe = 200;
        private static readonly int maxNumOfIngredients = 50;
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
            labelMode.Text = editModeLMAO;
            textBoxName.MaxLength = 50;
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

        private void buttonAddIngredients_Click(object sender, EventArgs e)
        {
            FormIngredients fi = new FormIngredients(currRecipe);
            DialogResult dlgResult = fi.ShowDialog();

            if (dlgResult != DialogResult.OK) return;
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                rm.ChangeRecipeAt(listBoxRecipe.SelectedIndex, currRecipe);
                currRecipe = rm.GetRecipeAt(listBoxRecipe.SelectedIndex);
            }
            else
            {
                if (currRecipe.GetNumberOfIngredients() <= 0)
                {
                    MessageBox.Show($@"No ingredient specified", $@"Error");
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
        }

        private void buttonEditBegin_Click(object sender, EventArgs e)
        {
            if (rm.GetNumberOfRecipes() <= 0) return;
            editMode = true;
            labelMode.Text = editModeLMAO;
            currRecipe = rm.GetRecipeAt(listBoxRecipe.SelectedIndex);
            textBoxName.Text = currRecipe.Name;
            textBoxDescription.Text = currRecipe.Description;
            comboBoxCategory.SelectedItem = currRecipe.Category;
        }

        private void buttonEditFinish_Click(object sender, EventArgs e)
        {
            editMode = false;
            currRecipe = new Recipe(maxNumOfIngredients);
            labelMode.Text = editModeLMAO;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            rm.RemoveAt(listBoxRecipe.SelectedIndex);
            listBoxRecipe.DataSource = rm.GetRecipes();
        }

        private void buttonClearSelection_Click(object sender, EventArgs e)
        {
            rm = new RecipeManager();
            listBoxRecipe.DataSource = rm.GetRecipes();
        }

        private void listBoxRecipe_DoubleClick(object sender, EventArgs e)
        {
            Recipe r = rm.GetRecipeAt(listBoxRecipe.SelectedIndex);
            MessageBox.Show($"Ingredients\n" +
                            $"{string.Join(", ", r.Ingredients)}\n\n" +
                            $"Description\n" +
                            $"{r.Description}", $@"{r.Name}");
        }

        private void listBoxRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!editMode) return;
            labelMode.Text = editModeLMAO;
            currRecipe = rm.GetRecipeAt(listBoxRecipe.SelectedIndex);
            textBoxName.Text = currRecipe.Name;
            textBoxDescription.Text = currRecipe.Description;
            comboBoxCategory.SelectedItem = currRecipe.Category;
        }
    }
}