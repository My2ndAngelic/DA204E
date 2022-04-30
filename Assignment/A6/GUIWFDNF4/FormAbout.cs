using System;
using System.Reflection;
using System.Windows.Forms;

namespace GUIWFDNF4
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        ///     Initializing the GUI
        /// </summary>
        private void InitializeGUI()
        {
            // Source: https://kencenerelli.wordpress.com/2015/09/26/understanding-the-visual-studio-assemblyinfo-class/

            Text = $@"About {((AssemblyProductAttribute) Attribute.GetCustomAttribute(
                    Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute), false))
                .Product}";
            labelTitle.Text = ((AssemblyTitleAttribute) Attribute.GetCustomAttribute(
                    Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute), false))
                .Title;
            labelCompany.Text = ((AssemblyCompanyAttribute) Attribute.GetCustomAttribute(
                    Assembly.GetExecutingAssembly(), typeof(AssemblyCompanyAttribute), false))
                .Company;
            labelProduct.Text = ((AssemblyProductAttribute) Attribute.GetCustomAttribute(
                    Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute), false))
                .Product;
            labelDescription.Text = ((AssemblyDescriptionAttribute) Attribute.GetCustomAttribute(
                    Assembly.GetExecutingAssembly(), typeof(AssemblyDescriptionAttribute), false))
                .Description;
            labelCopyright.Text = ((AssemblyCopyrightAttribute) Attribute.GetCustomAttribute(
                    Assembly.GetExecutingAssembly(), typeof(AssemblyCopyrightAttribute), false))
                .Copyright;
            labelVersion.Text = $@"Version: {Assembly.GetExecutingAssembly().GetName().Version}";
            buttonOK.Text = @"OK";
        }

        /// <summary>
        ///     Close the dialog
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
