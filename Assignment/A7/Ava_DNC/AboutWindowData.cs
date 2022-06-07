using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace Ava_DNC
{
    public sealed class AboutWindowData : INotifyPropertyChanged
    {
        public string _tTitle = $"About {((AssemblyProductAttribute) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyProductAttribute), false)).Product}";
        public string _tAbout =
            $@"Designed by {((AssemblyCompanyAttribute) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyCompanyAttribute), false))?.Company} in May 2022.
Version: {Assembly.GetExecutingAssembly().GetName().Version}
Description: {((AssemblyDescriptionAttribute) Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyDescriptionAttribute), false))?.Description}

OS: {RuntimeInformation.OSDescription} {RuntimeInformation.OSArchitecture} on {RuntimeInformation.ProcessArchitecture} CPU.
.NET version: {Environment.Version}
CLR version: {RuntimeEnvironment.GetSystemVersion()}
Timezone: UTC {DateTime.Now:zzz}

Future expansions:
- Match import and viewer
- More accurate counter
- Lower memory usage
- Cross platform compatibility";

        public event PropertyChangedEventHandler? PropertyChanged;

        public string TTitle
        {
            get { return _tTitle; }
            set { _tTitle = value; }
        }

        public string TAbout
        {
            get { return _tAbout; }
            set { _tAbout = value; }
        }

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}