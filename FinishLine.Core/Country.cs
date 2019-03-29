using KBCsv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FinishLine.Core
{
    public class Country
    {
        public List<string> CountryCode { get; set; }
        public List<string> SlovakShortName { get; set; }
        public List<string> EnglishShortName { get; set; }
        public List<string> OfficialShortName { get; set; }
        public List<string> DependencyOf { get; set; }


        public void LoadCountry(string path)
        {
            CountryCode = new List<string>(250);
            SlovakShortName = new List<string>(250);
            EnglishShortName = new List<string>(250);
            OfficialShortName = new List<string>(250);
            DependencyOf = new List<string>(250);
            StreamReader reader = new StreamReader(path);
            
            using(CsvReader cswReader = new CsvReader(reader))
            {
                cswReader.ValueSeparator = ';';
                var headerRow = cswReader.ReadHeaderRecord();

                while (cswReader.HasMoreRecords)
                {
                    var dataRecord = cswReader.ReadDataRecord();
                    CountryCode.Add(dataRecord["CountryCode"]);
                    SlovakShortName.Add(dataRecord["SlovakShortName"]);
                    EnglishShortName.Add(dataRecord["EnglishShortName"]);
                    OfficialShortName.Add(dataRecord["OfficialShortName"]);
                    DependencyOf.Add(dataRecord["DependencyOf"]);
                }
            }
        }
    }
}
