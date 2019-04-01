using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RaceResult
    {
        public int Id { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }
        public TimeSpan BestLap { get; set; }
        public TimeSpan RaceTime { get; set; }
        public double AverageSpeed { get; set; }


        public RaceResult(int id, int position, string name, TimeSpan bestLap, TimeSpan raceTime, double averageSpeed)
        {
            Id = id;
            Position = position;
            Name = name;
            BestLap = bestLap;
            RaceTime = raceTime;
            AverageSpeed = averageSpeed;
        }
        public RaceResult(int id)
        {
            Id = id;
        }
        public RaceResult()
        {

        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Id}");
            sb.Append($"\t");
            sb.Append($"{Position}");
            sb.Append($"\t");
            sb.Append($"{Name}");
            sb.Append($"\t");
            sb.Append($"{BestLap}");
            sb.Append($"\t");
            sb.Append($"{RaceTime}");
            sb.Append($"\t");
            sb.Append($"{AverageSpeed}");
            sb.AppendLine();
            return sb.ToString();
        }
    }
}
