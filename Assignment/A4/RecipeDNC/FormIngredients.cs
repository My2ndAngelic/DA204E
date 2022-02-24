using System;
using System.Windows.Forms;
using RecipeLibrary;

namespace RecipeDNC
{
    public partial class FormIngredients : Form
    {
        private Recipe recipe;

        public FormIngredients(Recipe recipe)
        {
            this.recipe = recipe;
            InitializeComponent();
            InitializeGUI();
            foreach (string s in recipe.Ingredients)
            {
                if (s == null) continue;
                listBoxIngredient.Items.Add(s);
            }
        }
        
        public FormIngredients()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            labelNumOfIngLeft.Text = recipe.Name == string.Empty ? "New recipe" : recipe.Name;
            labelNumOfIngRight.Text = $@"Number of ingredients: {recipe.GetNumberOfIngredients().ToString()}";
        }

        public void EditRecipe(string[] recipes)
        {
            listBoxIngredient.DataSource = recipes;
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            foreach (string s in listBoxIngredient.Items)
            {
                recipe.AddIngredientBinary(s);
            }
            
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            if (textBoxIngredient.Text != string.Empty)
            {
                if (listBoxIngredient.SelectedIndex != -1)
                    listBoxIngredient.Items.Insert(listBoxIngredient.SelectedIndex, textBoxIngredient.Text);
                else
                    listBoxIngredient.Items.Add(textBoxIngredient.Text);
            }

            textBoxIngredient.Text = string.Empty;
            labelNumOfIngRight.Text = $@"Number of ingredients: {listBoxIngredient.Items.Count}";
        }

        private void buttonEdit_Click(object sender, System.EventArgs e)
        {
            if (textBoxIngredient.Text != string.Empty)
                listBoxIngredient.Items[listBoxIngredient.SelectedIndex] = textBoxIngredient.Text;
            textBoxIngredient.Text = string.Empty;
        }

        private void buttonDelete_Click(object sender, System.EventArgs e)
        {
            listBoxIngredient.Items.RemoveAt(listBoxIngredient.SelectedIndex);
            textBoxIngredient.Text = string.Empty;
            labelNumOfIngRight.Text = $@"Number of ingredients: {listBoxIngredient.Items.Count}";
        }

        private void listBoxIngredient_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }

        private void labelNumOfIngRight_Click(object sender, System.EventArgs e)
        {
        }

    }
}