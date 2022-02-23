using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecipeLibrary;

namespace RecipeDNC
{
    public partial class FormMain : Form
    {
        private RecipeManager rm = new RecipeManager(maxNumOfRecipe);
        private bool editMode;
        private Recipe currRecipe = new Recipe(maxNumOfIngredients);
        private static readonly int maxNumOfRecipe = 200;
        private static readonly int maxNumOfIngredients = 50;

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            InitializeGroupBox();
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
            if (currRecipe.GetNumberOfIngredients() <= 0)
                MessageBox.Show("No ingredient specified", "Error");
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            if (editMode)
                rm.ChangeRecipeAt(listBoxRecipe.SelectedIndex, currRecipe);
            else
                rm.Add(new Recipe(
                        textBoxName.Text, 
                        (FoodCategory) Enum.Parse(typeof(FoodCategory), 
                        comboBoxCategory.SelectedValue.ToString() ?? string.Empty),
                        currRecipe.Ingredients,
                        textBoxDescription.Text));
            listBoxRecipe.DataSource = rm.GetRecipes();
        }

        private void buttonEditBegin_Click(object sender, EventArgs e)
        {
            if (rm.GetNumberOfRecipes() <= 0) return;
            editMode = true;
            currRecipe = rm.GetRecipeAt(listBoxRecipe.SelectedIndex);
            textBoxName.Text = currRecipe.Name;
            textBoxDescription.Text = currRecipe.Description;
            comboBoxCategory.SelectedItem = currRecipe.Category;
        }

        private void buttonEditFinish_Click(object sender, EventArgs e)
        {
            editMode = false;
            currRecipe = new Recipe(maxNumOfIngredients);
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
            MessageBox.Show($@"{r}", $@"{r.Name}");
        }
    }
}
