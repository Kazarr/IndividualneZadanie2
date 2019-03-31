using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RunnerViewModel
    {
        public List<Runner> Runners { get; set; } 
        public RunnerViewModel()
        {
            Runners = new List<Runner>();
        }



        public void SaveRunners(int id, string name, Country country, int age, string sex, int gridRowIndex)
        {
            Runner runner = Factory.Factory.CreateRunner(id, name, country, age, sex);
            try
            {
                Runners.RemoveAt(gridRowIndex);
                Runners.Add(runner);
            }
            catch(ArgumentOutOfRangeException e)
            {
                Runners.Add(runner);
            }
        }
        public void RemoveRunners(int gridRowIndex)
        {
            Runners.RemoveAt(gridRowIndex);
        }

    }
}
