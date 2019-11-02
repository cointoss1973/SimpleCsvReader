using System;
using System.Collections.Generic;
using Xunit;

namespace SimpleCsvReader.Tests
{
    public class CsvReaderTest
    {
        [Theory]
        [InlineData("Windows10Version.csv")]
        public void ReadTest(string fileName)
        {
            List<string[]> rows = CsvReader.Read(fileName);

            var versionList = new List<Windows10>();
            foreach (var row in rows)
            {
                var windows = new Windows10()
                { 
                    Build = row[0],
                    Version = row[1],
                    MarketingName = row[2],
                    ReleaseDate = row[3],
                };
                versionList.Add(windows);
            }
        }
    }
    public class Windows10
    {
        public string Build { get; set; }
        public string Version { get; set; }
        public string MarketingName { get; set; }
        public string ReleaseDate { get; set; }

        public override string ToString()
        {
            return $"{Build} Version: {Version} Name: {MarketingName} Date: {ReleaseDate}";
        }
    }
}
