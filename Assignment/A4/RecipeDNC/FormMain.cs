using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RecipeLibrary; // Backend saved in a separate project.

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

        private void InitializeGUI()
        {
            Text = @"Apu Recipe Editor by Evan Huynh";
            InitializeRecipeEditor();
            InitializeResultBox();
            UpdateGUI();
        }


        private void InitializeRecipeEditor()
        {
            groupBoxRecipeEditor.Text = @"Recipe Editor";

            comboBoxCategory.DataSource = Enum.GetValues(typeof(FoodCategory));
            comboBoxCategory.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCategory.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            
            textBoxName.Text = string.Empty;
            textBoxDescription.Text = string.Empty;

            labelName.Text = @"Name";
            labelCategory.Text = @"Category";
        }


        private void InitializeResultBox()
        {
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
            testSuite(69);
        }

        private void buttonAddIngredients_Click(object sender, EventArgs e)
        {
            FormIngredient fi = new FormIngredient(currRecipe);
            DialogResult dlgResult = fi.ShowDialog();

            if (dlgResult == DialogResult.OK)
                currRecipe = fi.Recipe;
        }

        private void buttonAddRecipe_Click(object sender, EventArgs e)
        {
            if (currRecipe.GetNumberOfIngredients() <= 0)
            {
                MessageBox.Show(@"No ingredient specified.", @"Error");
                return;
            }

            if (editMode)
            {
                if (rm.ChangeRecipeAt(listBoxRecipe.SelectedIndex, new Recipe(
                        textBoxName.Text,
                        (FoodCategory) Enum.Parse(typeof(FoodCategory),
                            comboBoxCategory.SelectedValue.ToString() ?? string.Empty),
                        currRecipe.Ingredients,
                        textBoxDescription.Text,
                        maxNumOfIngredients)))
                {
                    labelMode.Text = @"Recipe saved";
                    listBoxRecipe.DataSource = rm.GetRecipes();
                }
                else
                {
                    MessageBox.Show(@"Something is wrong. Please try again", @"Error");
                }
            }
            else
            {
                if (rm.Add(new Recipe(
                        textBoxName.Text,
                        (FoodCategory) Enum.Parse(typeof(FoodCategory),
                            comboBoxCategory.SelectedValue.ToString() ?? string.Empty),
                        currRecipe.Ingredients,
                        textBoxDescription.Text,
                        maxNumOfIngredients)))
                {
                    currRecipe = new Recipe(maxNumOfIngredients);
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

        private void buttonEditBegin_Click(object sender, EventArgs e)
        {
            if (rm.GetNumberOfRecipes() <= 0) return;
            editMode = true;
            currRecipe = new Recipe(rm.GetRecipeAt(listBoxRecipe.SelectedIndices[0]));

            // GUI
            UpdateGUI();
        }

        private void UpdateGUI()
        {
            if (editMode)
            {
                labelMode.Text = @"Edit mode";
                textBoxName.Text = currRecipe.Name;
                textBoxDescription.Text = currRecipe.Description;
                buttonAddIngredients.Text = @"Edit ingredients";
                buttonAddRecipe.Text = @"Save recipe";
                comboBoxCategory.SelectedItem = currRecipe.Category;
            }
            else
            {
                labelMode.Text = @"Add mode";
                textBoxName.Text = string.Empty;
                textBoxDescription.Text = string.Empty;
                buttonAddIngredients.Text = @"Add ingredients";
                buttonAddRecipe.Text = @"Add recipe";
                comboBoxCategory.SelectedIndex = 0;
            }
        }

        private void buttonEditFinish_Click(object sender, EventArgs e)
        {
            editMode = false;
            currRecipe = new Recipe(maxNumOfIngredients);

            // GUI
            UpdateGUI();
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
            UpdateGUI();
            listBoxRecipe.DataSource = rm.GetRecipes();
        }

        private void listBoxRecipe_DoubleClick(object sender, EventArgs e)
        {
            Recipe r = rm.RecipeListToString(listBoxRecipe.SelectedIndex);
            MessageBox.Show(r.ToString(),
                $@"{r.Name}");
        }

        private void listBoxRecipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!editMode) return;
            currRecipe = rm.GetRecipeAt(listBoxRecipe.SelectedIndex);
            textBoxName.Text = currRecipe.Name;
            textBoxDescription.Text = currRecipe.Description;
            comboBoxCategory.SelectedItem = currRecipe.Category;
        }

        private void listBoxRecipe_MouseDown(object sender, MouseEventArgs e)
        {
            if (editMode) return;
            if (listBoxRecipe.IndexFromPoint(e.Location) == -1 || e.Button == MouseButtons.Right)
                listBoxRecipe.ClearSelected();
        }

        private void listBoxRecipe_KeyDown(object sender, KeyEventArgs e)
        {
            if (!e.Control || e.KeyCode != Keys.A) return;
            for (int i = 0; i < listBoxRecipe.Items.Count; i++) listBoxRecipe.SetSelected(i, true);
        }
        
        private void testSuite(int num)
        {
            string[] s =
            {
                "cremini mushrooms",
                "alligator",
                "cornstarch",
                "pomegranates",
                "apple butter",
                "pinto beans",
                "cheddar cheese",
                "herring",
                "artichokes",
                "leeks",
                "pink beans",
                "corn flour",
                "alfredo sauce",
                "brunoise",
                "soymilk",
                "fish sauce",
                "chai",
                "pickles",
                "cod",
                "ale",
                "vegemite",
                "white chocolate",
                "raspberries",
                "orange peels",
                "condensed milk",
                "kidney beans",
                "watermelons",
                "marshmallows",
                "cucumbers",
                "pepper",
                "breadfruit",
                "won ton skins",
                "prunes",
                "chicory",
                "prawns",
                "snap peas",
                "summer squash",
                "squash",
                "raisins",
                "Havarti cheese",
                "rice vinegar",
                "bean threads",
                "couscous",
                "lima beans",
                "powdered sugar",
                "cabbage",
                "green onions",
                "ice cream",
                "halibut",
                "okra"
            };
            for (int i = 0; i < num; i++)
                rm.Add(new Recipe($"Ur Mom {i}",
                    (FoodCategory) typeof(FoodCategory).GetEnumValues().OfType<Enum>().OrderBy(e => Guid.NewGuid())
                        .FirstOrDefault()!, s.OrderBy(x => new Random().Next()).ToArray(), @"Step 1
Preheat oven to 375 degrees F (190 degrees C). Lightly grease a large baking sheet.

Step 2
In a large bowl, mix together flour, sugar, baking soda, baking powder, salt and margarine. Stir in 1 cup of buttermilk and egg. Turn dough out onto a lightly floured surface and knead slightly. Form dough into a round and place on prepared baking sheet. In a small bowl, combine melted butter with 1/4 cup buttermilk; brush loaf with this mixture. Use a sharp knife to cut an 'X' into the top of the loaf.

Step 3
Bake in preheated oven until a toothpick inserted into the center of the loaf comes out clean, 45 to 50 minutes. Check for doneness after 30 minutes. You may continue to brush the loaf with the butter mixture while it bakes."));

            listBoxRecipe.DataSource = rm.GetRecipes();
        }
    }
}