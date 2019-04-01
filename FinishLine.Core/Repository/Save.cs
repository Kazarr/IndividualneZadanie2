using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinishLine.Core.Repository
{
    public class Save
    {
        public RaceViewModel RaceViewModel { get; set; }
        public RunnerViewModel RunnerViewModel { get; set; }
        public string FilePath { get; set; }
        public Save(RaceViewModel raceViewModel, RunnerViewModel runnerViewModel)
        {
            RaceViewModel = raceViewModel;
            RunnerViewModel = runnerViewModel;
        }
        public Save(RunnerViewModel runnerViewModel)
        {
            RunnerViewModel = runnerViewModel;
        }
        public void SaveRunners(string path)
        {
            foreach (Runner r in RunnerViewModel.Runners)
            {
                File.AppendAllText(path, r.ToString());
            }
        }
        public void SaveRace(string path)
        {
            string lapPath = Path.Combine(path,"laps.lp");
            foreach(FinishedLap fl in RaceViewModel.LapGridData)
            {
                File.AppendAllText(lapPath, fl.ToString());
            }

            string racePath = Path.Combine(path, "race.rc");
            foreach(RaceResult rc in RaceViewModel.RaceGridData)
            {
                File.AppendAllText(racePath, rc.ToString());
            }
        }
        
    }
}
