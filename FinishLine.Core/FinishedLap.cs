using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class FinishedLap
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int FinishedLaps { get; set; }
        public TimeSpan FinishedLapTime { get; set; }

        public FinishedLap(int id, int position, string name, string country, int finishedLaps, TimeSpan finishedLapTime)
        {
            Id = id;
            Position = position;
            Name = name;
            Country = country;
            FinishedLaps = finishedLaps;
            FinishedLapTime = finishedLapTime;
        }
        public FinishedLap(int id)
        {
            Id = id;

        }
        public FinishedLap()
        {

        }
    }
}
