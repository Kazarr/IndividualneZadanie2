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

        public RaceViewModel(List<Runner> runners, int lapCount, int reward, DateTime date, int lapLenght)
        {
            //LapGridData.Add(Factory.Factory.CreateRace(runners, lapCount, reward, date, lapLenght));
            //LapFinished = new Stack<Runner>();
        }

        //public void RaceStart(List<Runner> runners, int lapCount, int reward, DateTime date, int lapLenght)
        //{
        //    foreach(Runner r in RunnerViewModel.Runners)
        //    {
        //        r.TotalTime = 
        //    }
        //}
        public void RaceStart(DateTime dateTimeRaceStart)
        {
            foreach (Runner r in RunnerViewModel.Runners)
            {
                r.TotalTime = dateTimeRaceStart;
            }
        }
        //public void FinishLap(int id, DateTime dateTime)
        //{
        //    Runner runner = RunnerViewModel.GetRunnerById(id);
        //    FinishedLap finishedLap = Factory.Factory.CreateFinishedLap(id);
        //    for (int i = 0; i < RunnerViewModel.Runners.Count; i++)
        //    {
        //        if(RunnerViewModel.Runners[i].Id == id)
        //        {
        //            finishedLap.Name = RunnerViewModel.Runners[i].Name;
        //            finishedLap.Country = RunnerViewModel.Runners[i].Country.EnglishShortName;
        //            finishedLap.FinishedLaps = RunnerViewModel.Runners[i].FinishedLaps+1;
        //            RunnerViewModel.Runners[i].FinishedLaps++;
        //            finishedLap.FinishedLapTime = dateTime - RunnerViewModel.Runners[i].TotalTime;
        //            RunnerViewModel.Runners[i].TotalTime = dateTime;
        //            if (LapGridData.Count <= 0)
        //            {
        //                finishedLap.Position = 1;
        //            }
        //            else if(LapGridData[i].Id == runner.Id)
        //            {
        //                if(LapGridData[i].FinishedLaps == runner.FinishedLaps)
        //                {
        //                    LapGridData[i].Position = 1;
        //                }

        //                finishedLap.Position = LapGridData[LapGridData.Count - 1].Position + 1;
        //            }
        //            else
        //            {
        //                if (LapGridData[i].FinishedLaps == runner.FinishedLaps)
        //                {

        //                }
        //            }
        //        }
        //    }
        //    Race.LapDate = dateTime;
        //    LapGridData.Add(finishedLap);
        //}

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
