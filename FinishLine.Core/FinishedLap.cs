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
        //public int Position { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int FinishedLaps { get; set; }
        public TimeSpan FinishedLapTime { get; set; }
        public double AverageSpeed { get; set; }
        //public DateTime LapTime { get; set; }

        public FinishedLap(int id, string name, string country, int finishedLaps, TimeSpan finishedLapTime, double averageSpeed)
        {
            Id = id;
            //Position = position;
            Name = name;
            Country = country;
            FinishedLaps = finishedLaps;
            FinishedLapTime = finishedLapTime;
            AverageSpeed = averageSpeed;
        }
        public FinishedLap(int id)
        {
            Id = id;

        }
        public FinishedLap()
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Id}");
            sb.Append($"\t");
            sb.Append($"{Name}");
            sb.Append($"\t");
            sb.Append($"{Country}");
            sb.Append($"\t");
            sb.Append($"{FinishedLaps}");
            sb.Append($"\t");
            sb.Append($"{FinishedLapTime}");
            sb.Append($"\t");
            sb.Append($"{AverageSpeed}");
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
