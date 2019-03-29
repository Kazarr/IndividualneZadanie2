using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KBCsv;

namespace FinishLine.Core.Repository
{
    public static class Load
    {
        public static List<String> LoadCountryCode(string path)
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
                }
            }
            return CountryCode;
        }
        public static List<String> LoadSlovakShortName(string path)
        {
            List<string> SlovakShortName = new List<string>(250);

            StreamReader reader = new StreamReader(path);

            using (CsvReader cswReader = new CsvReader(reader))
            {
                cswReader.ValueSeparator = ';';
                var headerRow = cswReader.ReadHeaderRecord();

                while (cswReader.HasMoreRecords)
                {
                    var dataRecord = cswReader.ReadDataRecord();
                    SlovakShortName.Add(dataRecord["SlovakShortName"]);
                }
            }
            return SlovakShortName;
        }
        public static List<String> LoadEnglishShortName(string path)
        {
            List<string> EnglishShortName = new List<string>(250);

            StreamReader reader = new StreamReader(path);

            using (CsvReader cswReader = new CsvReader(reader))
            {
                cswReader.ValueSeparator = ';';
                var headerRow = cswReader.ReadHeaderRecord();

                while (cswReader.HasMoreRecords)
                {
                    var dataRecord = cswReader.ReadDataRecord();
                    EnglishShortName.Add(dataRecord["EnglishShortName"]);
                }
                return EnglishShortName;
            }
        }
        public static List<String> LoadOfficialShortName(string path)
        {
            List<string> OfficialShortName = new List<string>(250);

            StreamReader reader = new StreamReader(path);

            using (CsvReader cswReader = new CsvReader(reader))
            {
                cswReader.ValueSeparator = ';';
                var headerRow = cswReader.ReadHeaderRecord();

                while (cswReader.HasMoreRecords)
                {
                    var dataRecord = cswReader.ReadDataRecord();
                    OfficialShortName.Add(dataRecord["OfficialShortName"]);
                }
            }
            return OfficialShortName;
        }
        public static List<Country> LoadCoutries(string path)
        {
            List<Country> ret = new List<Country>(250);

            StreamReader reader = new StreamReader(path);

            using (CsvReader cswReader = new CsvReader(reader))
            {
                cswReader.ValueSeparator = ';';
                var headerRow = cswReader.ReadHeaderRecord();

                while (cswReader.HasMoreRecords)
                {
                    var dataRecord = cswReader.ReadDataRecord();
                    ret.Add(new Country(dataRecord["CountryCode"], dataRecord["SlovakShortName"], dataRecord["EnglishShortName"], dataRecord["OfficialShortName"]));

                }
            }
            return ret;
        }
    }
}
