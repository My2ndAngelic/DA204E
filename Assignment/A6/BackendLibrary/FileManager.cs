using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BackendLibrary
{
    public class FileManager
    {
        public static IEnumerable<string> FileReader(string location)
        {
            return File.ReadAllLines(location);
        }

        public static void FileWriter(string location, IEnumerable<string> data)
        {
            File.AppendAllLines(location, data);
        }
    }
}