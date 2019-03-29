using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core.Factory
{
    public static class Factory
    {
        public static Runner CreateRunner(int id, string name, Country country, int age, string sex)
        {
            Runner ret = new Runner(id, name, country, age, sex);
            return ret;
        }
        public static Runner CreateRunner(string name, Country country, int age, string sex)
        {
            Runner ret = new Runner(name, country, age, sex);
            return ret;
        }
        public static Race CreateRace(Dictionary<int, Runner> runners, int lapCount, int reward)
        {
            Race ret = new Race(runners, lapCount, reward);
            return ret;
        }
        public static List<Country> CreateCountries(List<string> countyCode, List<string> slovakShortName, List<string> englishShortName, List<string> officialShortName)
        {
            List<Country> ret = new List<Country>(countyCode.Count);
            for (int i = 0; i < countyCode.Count; i++)
            {
                ret.Add(new Country(countyCode[i], slovakShortName[i], englishShortName[i], officialShortName[i]));
            }
            return ret;
        }
        public static Lap CreateLap(int lenght, DateTime date)
        {
            Lap ret = new Lap(lenght, date);
            return ret;
        }
    }
}
