//Nasir Derrick Kevin Vaneitta
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingNinjas_SAT
{
    class Ninjas
    {
        
        public string Name { get; set; }
        int level = 0;
        string rank;

        public Ninjas(string n)
        {
            rank = "Beginner";
            level = 0;
            Name = n;
        }
        public void levelUp(int c) 
        {
            level += c;
            getRank(level);
        }
        
        private void getRank(int lvl)
        {
            if (lvl > 0 && lvl < 5) 
            {
                rank = "Beginner";
            }
            else if (lvl >= 5 && lvl < 10) 
            {
                rank = "Grasshopper";
            }
            else if (lvl >= 10 && lvl < 15) 
            {
                rank = "Journeyman";
            }
            else if (lvl >= 15 && lvl < 20) 
            {
                rank = "RockStar";
            }
            else if (lvl >= 20 && lvl < 25) 
            {
                rank = "Ninja";
            }
            else if (lvl >= 25) 
            {
                rank = "Jedi";
            }
        }
        public void print()
        {
            Console.WriteLine("Name: {0} Level: {1} Rank: {2}", Name, level, rank);
        }


    }
    
}
