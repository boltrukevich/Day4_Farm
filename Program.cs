using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Day4_Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Farm myFarm = new Farm();
            // Console.WriteLine($"Input farm area:");
            myFarm.FarmArea = 1000; // Convert.ToInt32(Console.ReadLine());

            string selection;
            bool ending = false;

            List<Building> buildings = new List<Building>();
            buildings.Add(new Building() { BuildingName = "Stable", BuildingArea = 20 });
            buildings.Add(new Building() { BuildingName = "Barn", BuildingArea = 40 });
            buildings.Add(new Building() { BuildingName = "Pigsties", BuildingArea = 15 });

            Menu();

            do
            {

                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        myFarm.FarmGetInfo();
                        ending = false;
                        Menu();
                        break;
                    case "2":
                        BuildingGetInfo();
                        ending = false;
                        Menu();
                        break;
                    case "3":
                        BuildingAddInfo(); 
                        ending = false;
                        Menu();
                        break;
                    case "4":
                        Console.WriteLine(selection);
                        ending = false;
                        Menu();
                        break;
                    case "5":
                        ending = false;
                        Menu();
                        break;
                    case "6":
                        ending = true;
                        Console.WriteLine($"Good bye...") ;
                        break;
                    default:
                        Console.WriteLine("Error. Press again...");
                        ending = false;
                        break;
                }
            } 
            while (!ending);

            void Menu()
            {
                Console.WriteLine();
                Console.WriteLine($"Select number:");
                Console.WriteLine($"1. Farm info.");
                Console.WriteLine($"2. Building info.");
                Console.WriteLine($"3. Add Building info.");
                Console.WriteLine($"4. Animal info.");
                Console.WriteLine($"5. Plant info.");
                Console.WriteLine($"6. Exit.");
            }

            void BuildingGetInfo()
            {
                Console.WriteLine();
                foreach (Building index in buildings)
                {
                    Console.WriteLine($"Name: {index.BuildingName}, Area: {index.BuildingArea}");
                }
            }

            void BuildingAddInfo()
            {
                Console.WriteLine();
                Console.WriteLine($"Input building name: ");
                string name = Console.ReadLine();
                Console.WriteLine($"Input building area: ");
                int area = Convert.ToInt32(Console.ReadLine());
                buildings.Add(new Building() { BuildingName = name, BuildingArea = area });
            }
        }
    }
}