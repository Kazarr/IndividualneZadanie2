using System;
using System.Collections.Generic;

namespace FinishLine.Core
{
    public class Race
    {
        private Dictionary<int, Runner> _runners;
        private int _lapCount;
        private int _reward;
        private Dictionary<int,Runner> _finishedRunners;
        private DateTime _date;
        private int _lapLenght;

        public Dictionary<int, Runner> Runners { get => _runners; set => _runners = value; }
        public int LapCount { get => _lapCount; set => _lapCount = value; }
        public int Reward { get => _reward; set => _reward = value; }
        public Dictionary<int,Runner> FinishedRunners { get => _finishedRunners; set => _finishedRunners = value; }
        public DateTime RaceDate { get => _date; set => _date = value; }
        public DateTime LapDate { get; set; }
        public int LapLenght { get => _lapLenght; set => _lapLenght = value; }



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

        public Race(Dictionary<int, Runner> runners, 
            int lapCount, 
            int reward, 
            DateTime date, 
            int lapLenght) 
        {
            Runners = new Dictionary<int, Runner>();
            LapCount = lapCount;
            Reward = reward;
            RaceDate = date;
            LapDate = date;
            LapLenght = lapLenght;
            FinishedRunners = new Dictionary<int, Runner>();
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
