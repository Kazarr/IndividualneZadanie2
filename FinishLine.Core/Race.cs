using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Race
    {
        private List<Runner> _runners;
        private Stack<Lap> _laps;
        private int _lapCount;
        private int _reward;

        public Race(List<Runner> runners, Stack<Lap> laps, int lapCount, int reward)
        {
            _runners = runners ?? throw new ArgumentNullException(nameof(runners));
            _laps = laps ?? throw new ArgumentNullException(nameof(laps));
            _lapCount = lapCount;
            _reward = reward;
        }


    }
}
