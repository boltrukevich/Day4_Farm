using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Farm
{
    public class Farm
    {
        public void FarmGetInfo()
        {
            Console.WriteLine($"Farm name: {FarmName}, Farm area: {FarmArea}");
        }

        public string FarmName { get; } = "DefaultFarm";

        public int FarmArea { get; set; }

        /*  {
            set
            {
                if (value < 50)
                {
                    Console.WriteLine("Area must be <= 50");
                }
                else
                {
                    FarmArea = value;
                }
            }

            get {return FarmArea;}

        }*/

        
        enum PlantBed
        {
            Small,
            Medium,
            Big
        }

        enum Building
        {
            Stable,
            Barn,
            Pigtie
        }
    }
}
