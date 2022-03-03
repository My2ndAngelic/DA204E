using System;
using System.Windows.Forms;
using RecipeLibrary;

namespace RecipeDNC
{
    public partial class FormIngredient : Form
    {
        private Recipe recipe;

        /// <summary>
        /// Constructor with recipe ready
        /// </summary>
        /// <param name="recipe"></param>
        public FormIngredient(Recipe recipe)
        {
            Recipe = recipe;
            InitializeComponent();
            InitializeGUI();
            foreach (string s in recipe.Ingredients)
            {
                if (s == null) continue;
                listBoxIngredient.Items.Add(s);
            }
        }

        public FormIngredient()
        {
            InitializeComponent();
            InitializeGUI();
        }

        public Recipe Recipe
        {
            get => recipe;
            set => recipe = value;
        }


        private void InitializeGUI()
        {
            Text = @"Ingredient Editor";
            groupBoxIngredient.Text = @"Ingredients list";

            buttonAdd.Text = @"Add";
            buttonEdit.Text = @"Edit";
            buttonDelete.Text = @"Delete";

            buttonOK.Text = @"OK";
            buttonCancel.Text = @"Cancel";

            labelNumOfIngLeft.Text = Recipe.Name == string.Empty ? "New recipe" : Recipe.Name;
            labelNumOfIngRight.Text = $@"Number of ingredients: {Recipe.GetNumberOfIngredients().ToString()}";
        }

        public void EditRecipe(string[] recipes)
        {
            listBoxIngredient.DataSource = recipes;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Recipe.Ingredients = new string[Recipe.Ingredients.Length];
            foreach (string s in listBoxIngredient.Items) Recipe.AddIngredientBinary(s);
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxIngredient.Text == string.Empty) return;
            if (listBoxIngredient.Items.Count >= Recipe.Ingredients.Length)
            {
                MessageBox.Show(@"Maximum ingredients reached.", @"Error");
            }
            else
            {
                if (listBoxIngredient.SelectedIndex != -1)
                    listBoxIngredient.Items.Insert(listBoxIngredient.SelectedIndex, textBoxIngredient.Text);
                else
                    listBoxIngredient.Items.Add(textBoxIngredient.Text);
                textBoxIngredient.Text = string.Empty;
                labelNumOfIngRight.Text = $@"Number of ingredients: {listBoxIngredient.Items.Count}";
                listBoxIngredient.SelectedIndex = -1;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxIngredient.Text != string.Empty)
                listBoxIngredient.Items[listBoxIngredient.SelectedIndex] = textBoxIngredient.Text;
            textBoxIngredient.Text = string.Empty;
            listBoxIngredient.SelectedIndex = -1;
        }

        /// <summary>
        ///     Source: https://stackoverflow.com/questions/13149486/delete-selected-items-from-listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (listBoxIngredient.SelectedIndex != -1)
                listBoxIngredient.Items.Remove(listBoxIngredient.SelectedItems[0]);

            labelNumOfIngRight.Text = $@"Number of ingredients: {listBoxIngredient.Items.Count}";
            listBoxIngredient.SelectedIndex = -1;
        }

        /// <summary>
        ///     Source:
        ///     https://stackoverflow.com/questions/14921478/why-when-clicking-mouse-right-button-on-listbox-its-working-everywhere-in-the-l
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxIngredient_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxIngredient.IndexFromPoint(e.Location) == -1 || e.Button == MouseButtons.Right)
                listBoxIngredient.ClearSelected();
        }

        private void listBoxIngredient_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control || e.KeyCode != Keys.A) return;
            for (int i = 0; i < listBoxIngredient.Items.Count; i++) listBoxIngredient.SetSelected(i, true);
        }
    }
}