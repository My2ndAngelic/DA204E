using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace GUIWFDNF4
{
    public partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
            InitializeGUI();
        }

        
        private void InitializeGUI()
        {
            label2.Text = AssemblyInfo.Product;
            label3.Text = AssemblyInfo.Copyright;
            label4.Text = AssemblyInfo.VersionFull;
        }
    }
    
    /// <summary>
    /// Source:
    /// https://stackoverflow.com/questions/187495/how-to-read-assembly-attributes
    /// http://lancelarsen.com/reading-values-from-assemblyinfo-cs/
    /// </summary>
    internal static class AssemblyInfo
        {
            public static string Company { get { return GetExecutingAssemblyAttribute<AssemblyCompanyAttribute>(a => a.Company); } }
            public static string Product { get { return GetExecutingAssemblyAttribute<AssemblyProductAttribute>(a => a.Product); } }
            public static string Copyright { get { return GetExecutingAssemblyAttribute<AssemblyCopyrightAttribute>(a => a.Copyright); } }
            public static string Trademark { get { return GetExecutingAssemblyAttribute<AssemblyTrademarkAttribute>(a => a.Trademark); } }
            public static string Title { get { return GetExecutingAssemblyAttribute<AssemblyTitleAttribute>(a => a.Title); } }
            public static string Description { get { return GetExecutingAssemblyAttribute<AssemblyDescriptionAttribute>(a => a.Description); } }
            public static string Configuration { get { return GetExecutingAssemblyAttribute<AssemblyConfigurationAttribute>(a => a.Configuration); } }
            public static string FileVersion { get { return GetExecutingAssemblyAttribute<AssemblyFileVersionAttribute>(a => a.Version); } }

            public static Version Version { get { return Assembly.GetExecutingAssembly().GetName().Version; } }
            public static string VersionFull { get { return Version.ToString(); } }
            public static string VersionMajor { get { return Version.Major.ToString(); } }
            public static string VersionMinor { get { return Version.Minor.ToString(); } }
            public static string VersionBuild { get { return Version.Build.ToString(); } }
            public static string VersionRevision { get { return Version.Revision.ToString(); } }

            private static string GetExecutingAssemblyAttribute<T>(Func<T, string> value) where T : Attribute
            {
                T attribute = (T)Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(T));
                return value.Invoke(attribute);
            }
        }
}