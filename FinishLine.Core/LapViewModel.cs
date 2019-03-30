using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class LapViewModel
    {
        public Lap Lap { get; set; }

        public LapViewModel(int lenght, DateTime date)
        {
            //FinishedLaps = Factory.Factory.CreateLap(lenght, date)
        }
    }
}
