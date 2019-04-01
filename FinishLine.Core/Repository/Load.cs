using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using KBCsv;
using System.ComponentModel;

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
        public static List<Country> LoadOrderedCountries(string path)
        {
            List<Country> ret = new List<Country>(250);
            ret = LoadCoutries(path);
            ret.Sort((x,y)=> x.EnglishShortName.CompareTo(y.EnglishShortName));
            return ret;

        }
        public static BindingList<Runner> LoadRunners(string path)
        {
            BindingList<Runner> ret = new BindingList<Runner>();
            string[] lines = File.ReadAllLines(path);
            for(int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split('\t');
                string txtId = line[0];
                string txtName = line[1];
                string txtCountry = line[2];
                string txtAge = line[3];
                string txtSex = line[4];
                int id = int.Parse(txtId);
                int age = int.Parse(txtAge);
                Country c = Factory.Factory.CreateCountry(txtCountry);
                Runner r = Factory.Factory.CreateRunner(id, txtName, c, age, txtSex);
                ret.Add(r);
            }
            return ret;
        }
        public static BindingList<FinishedLap> LoadFinishedLap(string path)
        {
            path = Path.Combine(path, "laps.lp");
            BindingList<FinishedLap> ret = new BindingList<FinishedLap>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] lapResult = lines[i].Split('\t');
                string txtId = lapResult[0];
                string txtName = lapResult[1];
                string txtCountry = lapResult[2];
                string txtFinishedLaps = lapResult[3];
                string txtFinishedLapTime = lapResult[4];
                string txtAverageSpeed = lapResult[5];
                int id = int.Parse(txtId);
                int finishedLaps = int.Parse(txtFinishedLaps);
                TimeSpan lapsTime = TimeSpan.Parse(txtFinishedLapTime);
                double average = double.Parse(txtAverageSpeed);
                FinishedLap fl = Factory.Factory.CreateFinishedLap(id, txtName, txtCountry, finishedLaps, lapsTime,average);
                ret.Add(fl);
            }
            return ret;
        }
        public static BindingList<RaceResult> LoadRaceResult(string path)
        {
            path = Path.Combine(path,"race.rc");
            BindingList<RaceResult> ret = new BindingList<RaceResult>();
            string[] lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] raceResult = lines[i].Split('\t');
                string txtId = raceResult[0];
                string txtPosition = raceResult[1];
                string txtName = raceResult[2];
                string txtBestTime = raceResult[3];
                string txtRaceTime = raceResult[4];
                string txtAverageSpeed = raceResult[5];
                int id = int.Parse(txtId);
                int position = int.Parse(txtPosition);
                TimeSpan bestTime = TimeSpan.Parse(txtBestTime);
                TimeSpan raceTime = TimeSpan.Parse(txtRaceTime);
                double average = double.Parse(txtAverageSpeed);
                RaceResult rr = Factory.Factory.CreateRaceResult(id,position, txtName, bestTime, raceTime, average);
                ret.Add(rr);
            }
            return ret;
        }
    }
}
