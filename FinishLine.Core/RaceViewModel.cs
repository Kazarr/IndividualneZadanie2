using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RaceViewModel
    {
        public RunnerViewModel RunnerViewModel { get; set; }
        public Race Race { get; set; }

        //public Stack<Runner> LapFinished { get; set; }

        //public RaceViewModel(Dictionary<int, Runner> runners, int lapCount, int reward, DateTime date, int lapLenght)
        //{
        //    Race = Factory.Factory.CreateRace(runners, lapCount, reward, date, lapLenght);
        //    //LapFinished = new Stack<Runner>();
        //}

        public void RaceStart(List<Runner> runners, int lapCount, int reward, DateTime date, int lapLenght)
        {
            Race = Factory.Factory.CreateRace(runners, lapCount, reward, date, lapLenght);
            Race.Runners = RunnerViewModel.Runners;
            //new RaceViewModel(
            //    RunnerViewModel.Runners,
            //    GetIntInput(txtLapCount.Text),
            //    GetIntInput(txtReward.Text),
            //    dateTime,
            //    GetIntInput(txtLapLenght.Text));
        }
        public void FinishLap(int id)
        {
            Race.Runners[id].FinishedLaps++;
        }

        public bool IsFinished(int id, int lapCount)
        {
            if(Race.Runners[id].FinishedLaps == lapCount)
            {
                Race.FinishedRunners.Add(Race.Runners[id]);
                return Race.Runners[id].IsFinished = true;

            }
            else
            {
                return Race.Runners[id].IsFinished = false;
            }
        }
    }
}
