using System.Collections.Generic;
using System.IO;

namespace BackendLibrary
{
    public class FileManager
    {
        /// <summary>
        ///     Read file and return the string array line by line
        /// </summary>
        /// <param name="location">File location</param>
        /// <returns>Array of strings line by line in the file</returns>
        public static IEnumerable<string> FileReader(string location)
        {
            return File.ReadAllLines(location);
        }

        /// <summary>
        ///     Append the existing file line by line
        /// </summary>
        /// <param name="location">File location</param>
        /// <param name="data">String array of every line needed to write</param>
        public static void FileAppender(string location, IEnumerable<string> data)
        {
            File.AppendAllLines(location, data);
        }

        /// <summary>
        ///     Replace the existing file with data line by line
        /// </summary>
        /// <param name="location">File location</param>
        /// <param name="data">String array of every line needed to write</param>
        public static void FileWriter(string location, IEnumerable<string> data)
        {
            File.WriteAllLines(location, data);
        }
    }
}
