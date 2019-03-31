using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class RunnerViewModel
    {
        public Dictionary<int, Runner> Runners { get; set; } 
        public RunnerViewModel()
        {
            Runners = new Dictionary<int, Runner>();
        }

        public void SaveRunners(int id, string name, Country country, int age, string sex)
        {
            if (Runners.ContainsKey(id))
            {
                if(!(Runners[id].Name == name && Runners[id].Country == country && Runners[id].Age == age && Runners[id].Sex == sex))
                {
                    Runners.Remove(id);
                    Runner r = Factory.Factory.CreateRunner(id, name, country, age, sex);
                    Runners.Add(id, r);
                }
            }
            else
            {
                Runner r = Factory.Factory.CreateRunner(id, name, country, age, sex);
                Runners.Add(id, r);
            }
            
        }

        private bool ContainsRunnerKey(int id)
        {
            return Runners.ContainsKey(id);
        }

    }
}
