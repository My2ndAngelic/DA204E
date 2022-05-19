using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows;

namespace WPF_DNC6
{
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
            InitializeGUI();
        }

        private void ButtonOK_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InitializeGUI()
        {
            Title =
                $"About {((AssemblyProductAttribute) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute), false)).Product}";
            TextTitle.Text =
                $"{((AssemblyTitleAttribute) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute), false)).Title}";
            TextAbout.Text =
                $@"Designed by {((AssemblyCompanyAttribute) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCompanyAttribute), false)).Company} in May 2022.
Version: {Assembly.GetExecutingAssembly().GetName().Version}
Description: {((AssemblyDescriptionAttribute) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyDescriptionAttribute), false)).Description}

OS: {RuntimeInformation.OSDescription} {RuntimeInformation.OSArchitecture}
.NET version: {Environment.Version}
Timezone: GMT/UTC{DateTime.Now:zzz}

Future expansions:
- Match import and viewer
- More accurate counter
- Lower memory usage
- Cross platform compatibility";
        }
    }
}