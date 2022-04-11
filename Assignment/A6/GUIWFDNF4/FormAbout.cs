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


        private void InitializeGUI()
        {
            label1.Text = AssemblyInfo.Title;
            label2.Text = AssemblyInfo.Company;
            label3.Text = AssemblyInfo.Product;
            label4.Text = AssemblyInfo.Description;
            label5.Text = AssemblyInfo.Copyright;
            label6.Text = $@"Version {AssemblyInfo.VersionFull}";
            button1.Text = @"OK";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }

    /// <summary>
    ///     Getting data from the AssemblyInfo.cs. I am used the one suggested by Lance Larsen.
    ///     Source:
    ///     https://stackoverflow.com/questions/187495/how-to-read-assembly-attributes
    ///     http://lancelarsen.com/reading-values-from-assemblyinfo-cs/
    /// </summary>
    internal static class AssemblyInfo
    {
        public static string Company
        {
            get { return GetExecutingAssemblyAttribute<AssemblyCompanyAttribute>(a => a.Company); }
        }

        public static string Product
        {
            get { return GetExecutingAssemblyAttribute<AssemblyProductAttribute>(a => a.Product); }
        }

        public static string Copyright
        {
            get { return GetExecutingAssemblyAttribute<AssemblyCopyrightAttribute>(a => a.Copyright); }
        }

        public static string Trademark
        {
            get { return GetExecutingAssemblyAttribute<AssemblyTrademarkAttribute>(a => a.Trademark); }
        }

        public static string Title
        {
            get { return GetExecutingAssemblyAttribute<AssemblyTitleAttribute>(a => a.Title); }
        }

        public static string Description
        {
            get { return GetExecutingAssemblyAttribute<AssemblyDescriptionAttribute>(a => a.Description); }
        }

        public static string Configuration
        {
            get { return GetExecutingAssemblyAttribute<AssemblyConfigurationAttribute>(a => a.Configuration); }
        }

        public static string FileVersion
        {
            get { return GetExecutingAssemblyAttribute<AssemblyFileVersionAttribute>(a => a.Version); }
        }

        public static Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }

        public static string VersionFull
        {
            get { return Version.ToString(); }
        }

        private static string GetExecutingAssemblyAttribute<T>(Func<T, string> value) where T : Attribute
        {
            T attribute = (T) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(T));
            return value.Invoke(attribute);
        }
    }
}