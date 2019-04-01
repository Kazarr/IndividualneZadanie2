
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
        public string CountryCode { get; set; }
        public string SlovakShortName { get; set; }
        public string EnglishShortName { get; set; }
        public string OfficialShortName { get; set; }
        public Country(string countryCode, string slovakShortName, string englishShortName, string officialShortName)
        {
            CountryCode = countryCode ?? throw new ArgumentNullException(nameof(countryCode));
            SlovakShortName = slovakShortName ?? throw new ArgumentNullException(nameof(slovakShortName));
            EnglishShortName = englishShortName ?? throw new ArgumentNullException(nameof(englishShortName));
            OfficialShortName = officialShortName ?? throw new ArgumentNullException(nameof(officialShortName));
        }


        public override string ToString()
        {
            return EnglishShortName;
        }

    }
}
