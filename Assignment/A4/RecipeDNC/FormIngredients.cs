using System.Windows.Forms;

namespace RecipeDNC
{
    public partial class FormIngredients : Form
    {
        public FormIngredients()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void InitializeGUI()
        {
            
        }

        public void EditRecipe(string[] recipes)
        {
            listBoxIngredient.DataSource = recipes;
        }

        private void buttonOK_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, System.EventArgs e)
        {
            if (textBoxIngredient.Text != string.Empty)
            {
                if (listBoxIngredient.SelectedIndex != -1)
                    listBoxIngredient.Items.Insert(listBoxIngredient.SelectedIndex, textBoxIngredient.Text);
                listBoxIngredient.Items.Add(textBoxIngredient.Text);
            }
            textBoxIngredient.Text = string.Empty;
            labelNumOfIngRight.Text = listBoxIngredient.Items.Count.ToString();
        }

        private void buttonEdit_Click(object sender, System.EventArgs e)
        {
            if (textBoxIngredient.Text != string.Empty)
                listBoxIngredient.Items[listBoxIngredient.SelectedIndex] = textBoxIngredient.Text;
            textBoxIngredient.Text = string.Empty;
            labelNumOfIngRight.Text = listBoxIngredient.Items.Count.ToString();
        }

        private void buttonDelete_Click(object sender, System.EventArgs e)
        {
            listBoxIngredient.Items.RemoveAt(listBoxIngredient.SelectedIndex);
            textBoxIngredient.Text = string.Empty;
            labelNumOfIngRight.Text = listBoxIngredient.Items.Count.ToString();
        }

        private void listBoxIngredient_SelectedIndexChanged(object sender, System.EventArgs e)
        {
        }

        private void labelNumOfIngRight_Click(object sender, System.EventArgs e)
        {

        }

    }
}