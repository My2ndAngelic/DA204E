using System;
using System.Windows.Forms;
using RecipeLibrary;

namespace RecipeDNC
{
    public partial class FormIngredient : Form
    {
        private Recipe recipe;

        /// <summary>
        ///     Constructor with recipe ready
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

        /// <summary>
        ///     Default constructor
        /// </summary>
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


        /// <summary>
        ///     Initialize the GUI
        /// </summary>
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

        /// <summary>
        ///     Control the event when the OK button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            Recipe.Ingredients = new string[Recipe.Ingredients.Length];
            foreach (string s in listBoxIngredient.Items)
                Recipe.AddIngredientBinary(s); // Add all ingredients from the box
            DialogResult = DialogResult.OK;
        }

        /// <summary>
        ///     Control the event when the Cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        ///     Control the event when the add button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxIngredient.Text == string.Empty) return; // If box is empty, do nothing
            if (listBoxIngredient.Items.Count >= Recipe.Ingredients.Length) // If max reached, show error, do not add
            {
                MessageBox.Show(@"Maximum ingredients reached.", @"Error");
            }
            else
            {
                if (listBoxIngredient.SelectedIndex != -1) // If selected at specific place
                    listBoxIngredient.Items.Insert(listBoxIngredient.SelectedIndex,
                        textBoxIngredient.Text); // Insert above
                else // if not selected
                    listBoxIngredient.Items.Add(textBoxIngredient.Text); // Add to the end
                UpdateGUI();
            }
        }

        /// <summary>
        ///     Control the event when Edit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (textBoxIngredient.Text != string.Empty)
                listBoxIngredient.Items[listBoxIngredient.SelectedIndex] =
                    textBoxIngredient.Text; // Only change the first selected element
            UpdateGUI();
        }

        /// <summary>
        ///     Source: https://stackoverflow.com/questions/13149486/delete-selected-items-from-listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            while (listBoxIngredient.SelectedIndex != -1) // Delete all selected elements
                listBoxIngredient.Items.Remove(listBoxIngredient.SelectedItems[0]);

            UpdateGUI();
        }

        /// <summary>
        ///     Right click or click an empty space in the box to deslect
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

        /// <summary>
        ///     Ctrl + A to Select All
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxIngredient_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control || e.KeyCode != Keys.A) return;
            for (int i = 0; i < listBoxIngredient.Items.Count; i++) listBoxIngredient.SetSelected(i, true);
        }

        /// <summary>
        ///     Update GUI after add, edit or delete
        /// </summary>
        private void UpdateGUI()
        {
            textBoxIngredient.Text = string.Empty;
            labelNumOfIngRight.Text = $@"Number of ingredients: {listBoxIngredient.Items.Count}";
            listBoxIngredient.SelectedIndex = -1;
        }
    }
}