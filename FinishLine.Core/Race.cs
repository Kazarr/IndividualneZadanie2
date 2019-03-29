using System;
using System.Collections.Generic;

namespace FinishLine.Core
{
    public class Race
    {
        private Dictionary<int, Runner> _runners;
        private int _lapCount;
        private int _reward;

        public Dictionary<int, Runner> Runners { get => _runners; set => _runners = value; }
        public int LapCount { get => _lapCount; set => _lapCount = value; }
        public int Reward { get => _reward; set => _reward = value; }

        public Race()
        {
        }

        public Race(int lapCount, int reward)
        {
            LapCount = lapCount;
            Reward = reward;
        }

        public Race(Dictionary<int, Runner> runners, int lapCount, int reward)
        {
            Runners = runners ?? throw new ArgumentNullException(nameof(runners));
            LapCount = lapCount;
            Reward = reward;
        }
        public void AddRunner(int Id, Runner runner)
        {
            Runners.Add(Id, runner);
        }
        public void RemoveRunner(int Id)
        {
            Runners.Remove(Id);
        }

    }
}
