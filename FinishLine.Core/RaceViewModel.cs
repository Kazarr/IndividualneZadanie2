using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RaceViewModel
    {
        public RunnerViewModel RunnerViewModel { get; set; }
        public BindingList<FinishedLap> LapGridData { get; set; }
        public Race Race { get; set; }

        //public Stack<Runner> LapFinished { get; set; }

        public RaceViewModel(RunnerViewModel runnerViewModel)
        {
            RunnerViewModel = runnerViewModel;
            LapGridData = new BindingList<FinishedLap>();
            Race = Factory.Factory.CreateRace();
        }

        public RaceViewModel(List<Runner> runners, int lapCount, int reward, DateTime date, int lapLenght)
        {
            //LapGridData.Add(Factory.Factory.CreateRace(runners, lapCount, reward, date, lapLenght));
            //LapFinished = new Stack<Runner>();
        }

        public void RaceStart(List<Runner> runners, int lapCount, int reward, DateTime date, int lapLenght)
        {
            //LapGridData.Add(Factory.Factory.CreateRace(runners, lapCount, reward, date, lapLenght));
            //LapGridData.Runners = RunnerViewModel.Runners.ToList();
            //new RaceViewModel(
            //    RunnerViewModel.Runners,
            //    GetIntInput(txtLapCount.Text),
            //    GetIntInput(txtReward.Text),
            //    dateTime,
            //    GetIntInput(txtLapLenght.Text));
        }
        public void FinishLap(int id, DateTime dateTime)
        {
            FinishedLap finishedLap = Factory.Factory.CreateFinishedLap(id);
            for (int i = 0; i < RunnerViewModel.Runners.Count; i++)
            {
                if(RunnerViewModel.Runners[i].Id == id)
                {
                    finishedLap.Position = RunnerViewModel.Runners[i].Position;
                    finishedLap.Name = RunnerViewModel.Runners[i].Name;
                    finishedLap.Country = RunnerViewModel.Runners[i].Country.EnglishShortName;
                    finishedLap.FinishedLaps = RunnerViewModel.Runners[i].FinishedLaps;
                    finishedLap.FinishedLapTime = Race.RaceDate - dateTime;
                    
                }
            }
            LapGridData.Add(finishedLap);
        }

        //public bool IsFinished(int id, int lapCount)
        //{
        //    //if (Race.Runners[id].FinishedLaps == lapCount)
        //    //{
        //    //    Race.FinishedRunners.Add(Race.Runners[id]);
        //    //    return Race.Runners[id].IsFinished = true;

        //    //}
        //    //else
        //    //{
        //    //    return Race.Runners[id].IsFinished = false;
        //    //}
        //}
    }
}
