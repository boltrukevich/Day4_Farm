using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Farm
{
    class Building
    {
        public void BuildingGetInfo()
        {
        }

        public string BuildingName { get; set; }
        public int BuildingArea { get; set; }
        public int BuildingAnimal { get; set; }
        public enum Animal
        {
            Horse,
            Pig,
            Cow,
            Sheep
        }
    }
}
