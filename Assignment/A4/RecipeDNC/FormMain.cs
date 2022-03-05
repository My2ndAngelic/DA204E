using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RecipeLibrary;

// Backend saved in a separate project.

namespace RecipeDNC
{
    public partial class FormMain : Form
    {
        private const int maxNumOfRecipe = 200;
        private const int maxNumOfIngredients = 50;
        private const int maxLengthRecipeName = 50;
        private Recipe currRecipe = new Recipe(maxNumOfIngredients);
        private bool editMode;
        private RecipeManager rm = new RecipeManager(maxNumOfRecipe);

        public FormMain()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        ///     First time GUI
        /// </summary>
        private void InitializeGUI()
        {
            Text = @"Apu Recipe Editor by Evan Huynh";
            InitializeRecipeEditor();
            InitializeResultBox();
            UpdateGUI();
        }


        /// <summary>
        ///     Recipe Editor init
        /// </summary>
        private void InitializeRecipeEditor()
        {
            groupBoxRecipeEditor.Text = @"Recipe Editor";

            comboBoxCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            comboBoxCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            textBoxName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;
        }

        /// <summary>
        ///     Result box and everything else
        /// </summary>
        private void InitializeResultBox()
        {
            labelName.Text = @"Name";
            labelCategory.Text = @"Category";
            labelRName.Text = @"Name";
            labelRCategory.Text = @"Category";
            labelRNoIng.Text = @"# of ingredients";

            listBoxRecipe.Font = new Font("Consolas", 9);
            textBoxName.MaxLength = maxLengthRecipeName;
            listBoxRecipe.SelectionMode = SelectionMode.MultiExtended;

            buttonEditBegin.Text = @"Begin editing";
            buttonEditFinish.Text = @"Finish editing";
            buttonDelete.Text = @"Delete";
            buttonClearAll.Text = @"Clear all";
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        ///     Control the event for the Add Ingredient button when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddIngredients_Click(object sender, EventArgs e)
        {
            FormIngredient fi = new FormIngredient(currRecipe);
            DialogResult dlgResult = fi.ShowDialog(); // Handling using Form Ingredients

            if (dlgResult == DialogResult.OK) // If OK -> get the recipe from the dialog
                currRecipe = fi.Recipe;
        }

        /// <summary>
        ///     Control the event for the add recipe button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            if (currRecipe.GetNumberOfIngredients() <= 0) // No ingredient, do not add, show error
            {
                MessageBox.Show(@"No ingredient specified.", @"Error");
                return;
            }

            if (editMode) // Edit mode
            {
                if (rm.ChangeRecipeAt(listBoxRecipe.SelectedIndex, new Recipe(
                        textBoxName.Text,
                        (FoodCategory) Enum.Parse(typeof(FoodCategory),
                            comboBoxCategory.SelectedValue.ToString() ?? string.Empty),
                        currRecipe.Ingredients,
                        textBoxDescription.Text,
                        maxNumOfIngredients))) // If changed unsuccessfully
                {
                    UpdateGUI();
                    listBoxRecipe.DataSource = rm.GetRecipes();
                    labelMode.Text = @"Recipe saved";
                }
                else
                {
                    MessageBox.Show(@"Something is wrong. Please try again", @"Error");
                }
            }
            else // Add mode
            {
                if (rm.Add(new Recipe(
                        textBoxName.Text,
                        (FoodCategory) Enum.Parse(typeof(FoodCategory),
                            comboBoxCategory.SelectedValue.ToString() ?? string.Empty),
                        currRecipe.Ingredients,
                        textBoxDescription.Text,
                        maxNumOfIngredients))) // If added successfully
                {
                    UpdateGUI();
                    listBoxRecipe.DataSource = rm.GetRecipes();
                    labelMode.Text = @"Recipe added";
                }
                else
                {
                    MessageBox.Show(@"Maximum number of recipe reached.", @"Error");
                }
            }
        }

        /// <summary>
        ///     Control the event when the edit Edit Begin button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditBegin_Click(object sender, EventArgs e)
        {
            if (rm.GetNumberOfRecipes() <= 0) return; // Empty list, no activation of edit mode
            editMode = true;
            currRecipe = new Recipe(rm.GetRecipeAt(listBoxRecipe.SelectedIndices[0]));

            // GUI
            UpdateGUI();
        }

        /// <summary>
        ///     Update GUI
        /// </summary>
        private void UpdateGUI()
        {
            if (editMode) // Edit mode
            {
                labelMode.Text = @"Edit mode";
                textBoxName.Text = currRecipe.Name;
                textBoxDescription.Text = currRecipe.Description;
                buttonAddIngredients.Text = @"Edit ingredients";
                buttonAddRecipe.Text = @"Save recipe";
                comboBoxCategory.SelectedItem = currRecipe.Category;
            }
            else // Add mode
            {
                labelMode.Text = @"Add mode";
                textBoxName.Text = string.Empty;
                textBoxDescription.Text = string.Empty;
                buttonAddIngredients.Text = @"Add ingredients";
                buttonAddRecipe.Text = @"Add recipe";
                comboBoxCategory.SelectedIndex = 0;
            }
        }

        /// <summary>
        ///     Control the event when Edit Finish button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditFinish_Click(object sender, EventArgs e)
        {
            editMode = false;
            currRecipe = new Recipe(maxNumOfIngredients);

            // GUI
            UpdateGUI();
        }

        /// <summary>
        ///     Control the event when the Delete button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRecipe.SelectedIndex != -1) // if at least one is selected
                for (int i = listBoxRecipe.SelectedItems.Count - 1; i >= 0; i--) // count how many is selected
                    rm.RemoveAt(listBoxRecipe.SelectedIndices[i]); // delete all of them
            listBoxRecipe.DataSource = rm.GetRecipes();
        }

        /// <summary>
        ///     Control the event when the Clear All button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            rm = new RecipeManager();
            editMode = false;
            UpdateGUI();
            listBoxRecipe.DataSource = rm.GetRecipes();
        }

        /// <summary>
        ///     Control the event when the element in the recipe box is double clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxRecipe_DoubleClick(object sender, EventArgs e)
        {
            Recipe r = rm.GetRecipeAt(listBoxRecipe.SelectedIndex);
            MessageBox.Show(r.ToString(),
                $@"{r.Name}");
        }

        /// <summary>
        ///     Control the event when different element is selected in the recipe box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            currRecipe = !editMode ? new Recipe(maxNumOfIngredients) : rm.GetRecipeAt(listBoxRecipe.SelectedIndex);
            textBoxName.Text = currRecipe.Name;
            textBoxDescription.Text = currRecipe.Description;
            comboBoxCategory.SelectedItem = currRecipe.Category;
        }

        /// <summary>
        ///     Control the event for the deselect by right click or click outside of the element but in the box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxRecipe_MouseDown(object sender, MouseEventArgs e)
        {
            if (editMode) return;
            if (listBoxRecipe.IndexFromPoint(e.Location) == -1 || e.Button == MouseButtons.Right)
                listBoxRecipe.ClearSelected();
        }

        /// <summary>
        ///     Only for Ctrl + A = Select All
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxRecipe_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control || e.KeyCode != Keys.A) return;
            for (int i = 0; i < listBoxRecipe.Items.Count; i++) listBoxRecipe.SetSelected(i, true);
        }
    }
}