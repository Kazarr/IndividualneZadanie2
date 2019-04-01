using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RunnerViewModel
    {
        public BindingList<Runner> Runners { get; set; } 
        public RunnerViewModel()
        {
            Runners = new BindingList<Runner>();
        }



        public void SaveRunners(int id, string name, Country country, int age, string sex)
        {
            Runner runner = Factory.Factory.CreateRunner(id, name, country, age, sex);
            //Runners.AddNew();
            Runners.Add(runner);

        }
        public void RemoveRunners(int gridRowIndex)
        {
            Runners.RemoveAt(gridRowIndex);
        }

    }
}
