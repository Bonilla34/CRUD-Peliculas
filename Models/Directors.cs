using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Movies.Models
{
    internal class Directors
    {
        public int PKDirector { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool Active { get; set; }

        public Directors(int pKDirector, string name, int age, bool active)
        {
            PKDirector = pKDirector;
            Name = name;
            Age = age;
            Active = active;
        }
    }
}
