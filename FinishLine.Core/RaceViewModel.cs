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
        public BindingList<RaceResult> RaceGridData { get; set; }
        public Race Race { get; set; }


        public RaceViewModel(RunnerViewModel runnerViewModel)
        {
            RunnerViewModel = runnerViewModel;
            LapGridData = new BindingList<FinishedLap>();
            RaceGridData = new BindingList<RaceResult>();
            Race = Factory.Factory.CreateRace();
        }

        public void RaceStart(DateTime dateTimeRaceStart)
        {
            foreach (Runner r in RunnerViewModel.Runners)
            {
                r.TotalTime = dateTimeRaceStart;
            }
        }
        

        public FinishedLap GetFinishedLapById(int id)
        {
            foreach(FinishedLap fl in LapGridData)
            {
                if(fl.Id == id)
                {
                    return fl;
                }
            }
            return null;
        }
        public void FinishLap(int id, DateTime dateTime)
        {
            Runner runner = RunnerViewModel.GetRunnerById(id);
            FinishedLap finishedLap = Factory.Factory.CreateFinishedLap(id);


            finishedLap.Name = runner.Name;
            finishedLap.Country = runner.Country.EnglishShortName;
            finishedLap.FinishedLaps = runner.FinishedLaps + 1;
            runner.FinishedLaps++;
            finishedLap.FinishedLapTime = dateTime - runner.TotalTime;
            runner.TotalTime = dateTime;
            finishedLap.AverageSpeed = Race.LapLenght / finishedLap.FinishedLapTime.TotalHours;
            
            Race.LapDate = dateTime;
            LapGridData.Add(finishedLap);
            if(runner.FinishedLaps == Race.LapCount)
            {
                TimeSpan ts = TimeSpan.MaxValue;
                double average = 0;
                for(int i = 0; i < LapGridData.Count; i++)
                {
                    if (ts > LapGridData[i].FinishedLapTime)
                    {
                        ts = LapGridData[i].FinishedLapTime;
                    }
                    average += LapGridData[i].AverageSpeed;
                    if (LapGridData.Count == i)
                    {
                        average = average / i;
                    }
                }
                RaceResult raceResult = Factory.Factory.CreateRaceResult(id);
                raceResult.Name = runner.Name;
                raceResult.Position = RaceGridData.Count + 1;
                raceResult.BestLap = ts;
                raceResult.RaceTime = dateTime - Race.RaceDate;
                raceResult.AverageSpeed = average;
                RaceGridData.Add(raceResult);
            }
        }

        
    }
}
