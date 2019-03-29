using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RunnerViewModel
    {
        public Dictionary<int, Runner> Runners { get; set; } //inicialize this!!!

        public RunnerViewModel()
        {
            Runners = new Dictionary<int, Runner>();
            //int id, string name, Country country, int age, string sex
            //Factory.Factory.CreateRunner(id, name, country, age, sex);
        }
    }
}
