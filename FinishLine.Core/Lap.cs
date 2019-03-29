using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Lap
    {
        private Queue<Runner> _finishedRunners;
        private DateTime _date;
        private int _lapLenght;

        public Lap(int lapLenght, DateTime date)
        {
            _finishedRunners = new Queue<Runner>();
            _lapLenght = lapLenght;
            _date = date;
        }
        public void FinishLap(Runner runner)
        {
            _finishedRunners.Enqueue(runner);
        }
    }
}
