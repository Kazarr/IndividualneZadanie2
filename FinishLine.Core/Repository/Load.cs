using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KBCsv;

namespace FinishLine.Core.Repository
{
    public class Load
    {
        public List<String> LoadCountryCode(string path)
        {
            List<string> CountryCode = new List<string>(250);

            StreamReader reader = new StreamReader(path);

            using (CsvReader cswReader = new CsvReader(reader))
            {
                cswReader.ValueSeparator = ';';
                var headerRow = cswReader.ReadHeaderRecord();

                while (cswReader.HasMoreRecords)
                {
                    var dataRecord = cswReader.ReadDataRecord();
                    CountryCode.Add(dataRecord["CountryCode"]);
                    //SlovakShortName.Add(dataRecord["SlovakShortName"]);
                    //EnglishShortName.Add(dataRecord["EnglishShortName"]);
                    //OfficialShortName.Add(dataRecord["OfficialShortName"]);
                    //DependencyOf.Add(dataRecord["DependencyOf"]);
                }
            }
            return CountryCode;
        }
    }
}
