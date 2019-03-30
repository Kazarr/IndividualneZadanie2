using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RaceViewModel
    {
        public Race Race { get; set; }


        public RaceViewModel(Dictionary<int, Runner> runners, int lapCount, int reward, DateTime date, int lapLenght)
        {
            Race = Factory.Factory.CreateRace(runners, lapCount, reward, date, lapLenght);
            Race.FinishedRunners = new Queue<Runner>();
        }

        public void RaceStart()
        {

        }
    }
}
