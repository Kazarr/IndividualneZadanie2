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

    }
}
