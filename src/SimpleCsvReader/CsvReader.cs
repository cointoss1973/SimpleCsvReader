using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SimpleCsvReader
{
    public static class CsvReader
    {
        /// <summary>
        /// Read all rows from csv file.
        /// </summary>
        /// <param name="fileName">file path</param>
        /// <returns></returns>
        public static List<string[]> Read(string fileName)
        {
            List<string[]> contents = new List<string[]>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Regex csvParser = new Regex(",(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))");

                    string[] elements = csvParser.Split(line);
                    contents.Add(elements);
                }
            }
            return contents;
        }
    }
}
