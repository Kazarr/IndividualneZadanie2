using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinishLine.Core
{
    public class Runner
    {
        private int _id;
        private string _name;
        private Country _country;
        private int _age;
        private string _sex;

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
        public int Lap { get; set; }
        /// <summary>
        /// Make a new runner with generated ID
        /// </summary>
        /// <param name="name">Name of the runner</param>
        /// <param name="country">Country the runner represents</param>
        /// <param name="age">Age of the runner</param>
        /// <param name="sex">Sex of the runner</param>
        public Runner(string name, Country country, int age, string sex)
        {
            _id = GenerateId();
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _country = country;
            _age = age;
            _sex = sex ?? throw new ArgumentNullException(nameof(sex));
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
            _id = id;
            _name = name ?? throw new ArgumentNullException(nameof(name));
            _country = country;
            _age = age;
            _sex = sex ?? throw new ArgumentNullException(nameof(sex));
        }
        private int GenerateId()
        {
            int ret = 0;
            Random r = new Random();
            return ret = r.Next(1, 1000);
        }

    }
}
