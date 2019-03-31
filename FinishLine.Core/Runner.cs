using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Runner : INotifyPropertyChanged
    {
        private int _id;
        private string _name;
        private Country _country;
        private int _age;
        private string _sex;

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Runners position in current lap. 
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// Returns true/false if the runner finished a race;
        /// </summary>
        public bool IsFinished { get; set; }
        /// <summary>
        /// Return current lap of runner;
        /// </summary>
        public int FinishedLaps { get; set; }
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public Country Country { get => _country; set => _country = value; }
        public int Age { get => _age; set => _age = value; }
        public string Sex { get => _sex; set => _sex = value; }

        public Runner()
        {

        }

        /// <summary>
        /// Make a new runner with generated ID
        /// </summary>
        /// <param name="name">Name of the runner</param>
        /// <param name="country">Country the runner represents</param>
        /// <param name="age">Age of the runner</param>
        /// <param name="sex">Sex of the runner</param>
        public Runner(string name, Country country, int age, string sex)
        {
            Id = GenerateId();
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Country = country;
            Age = age;
            Sex = sex ?? throw new ArgumentNullException(nameof(sex));
        }
        /// <summary>
        /// make a new runner with your ID
        /// </summary>
        /// <param name="id">Id of the runner</param>
        /// <param name="name">Name of the runner</param>
        /// <param name="country">Country the runner represents</param>
        /// <param name="age">Age of the runner</param>
        /// <param name="sex">Sex of the runner</param>
        public Runner(int id, string name, Country country, int age, string sex)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Country = country;
            Age = age;
            Sex = sex ?? throw new ArgumentNullException(nameof(sex));
        }
        private int GenerateId()
        {
            int ret = 0;
            Random r = new Random();
            return ret = r.Next(1, 1000);
        }

    }
}
