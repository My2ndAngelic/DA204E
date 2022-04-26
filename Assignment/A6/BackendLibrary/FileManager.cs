﻿using System.Collections.Generic;
using System.IO;

namespace BackendLibrary
{
    public class FileManager
    {
        public static IEnumerable<string> FileReader(string location)
        {
            return File.ReadAllLines(location);
        }

        public static void FileAppender(string location, IEnumerable<string> data)
        {
            File.AppendAllLines(location, data);
        }

        public static void FileWriter(string location, IEnumerable<string> data)
        {
            File.WriteAllLines(location, data);
        }
    }
}