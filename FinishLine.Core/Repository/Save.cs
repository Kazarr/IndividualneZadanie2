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
        public void SaveRunners(string path)
        {
            foreach (Runner r in RunnerViewModel.Runners)
            {
                File.AppendAllText(path, r.ToString());
            }
        }
        public void SaveRace()
        { 
            
        }
        
    }
}
