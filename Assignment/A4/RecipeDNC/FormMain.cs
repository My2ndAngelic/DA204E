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
        private RecipeManager rm = new RecipeManager();
        private bool editMode;


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
            FormIngredients fi = new FormIngredients();
            
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            rm.Add(new Recipe(textBoxName.Text, 
                    (FoodCategory) Enum.Parse(typeof(FoodCategory), 
                    comboBoxCategory.SelectedValue.ToString() ?? string.Empty),
                new[]{"ur", "mom"},
                    textBoxDescription.Text));
            listBoxRecipe.DataSource = rm.GetRecipes();
        }

        private void buttonEditBegin_Click(object sender, EventArgs e)
        {
            editMode = true;
        }

        private void buttonEditFinish_Click(object sender, EventArgs e)
        {
            editMode = false;
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
