using System;
using BackendLibrary;

namespace A6ConsoleDNF
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // TaskManager cm = new TaskManager();
            // Task c = new Task(new DateTime(2022, 3, 22), PriorityType.Important, "Say Hello");
            // cm.Add(c);
            // Console.WriteLine(cm[0].ToString());
            // Console.WriteLine(cm.Calendars);

            Task c = Task.FromStrings("1648511847|Very_important|Untitled".Split('|'));
            Console.WriteLine(c.ToString());
        }
    }
}