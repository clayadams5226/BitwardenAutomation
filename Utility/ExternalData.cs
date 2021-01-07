using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BitwardenAutomation.Utility
{
    class ExternalData
    {
        public static List<string> loadCsvFile(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            List<string> searchList = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            return searchList;
        }
        public static void filldatafromCsv()
        {
            string filePath = @"C:\Users\claya\Bitwarden\userData.csv";
            List<string> data = new List<string>();
            data = loadCsvFile(filePath);
            for (int i = 0; i < data.Count; i++)
            {
                var values = data[i].Split(',');
                Data.SetEmail(values[0]);
                Data.SetPassword(values[1]);

            }
        }

    }
}
