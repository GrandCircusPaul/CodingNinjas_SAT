using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingNinjas_SAT
{
    class CodingNinja
    {
        int level;
        string name;
        string rank;

        public string Rank 
        {
            get{ return rank;}
            
        }

        public CodingNinja()
        {

        }
        public CodingNinja(string n)
        {
            name = n;
        }
        private void setRank()
        {
            this.rank = getRank();
        }
        public string getRank()
        {
            switch(level/5)
            {
                case 0:
                    return "Beginner";
                    break;
                case 1:
                    return "Grasshopper";
                    break;
                case 2:
                    return "Journeyman";
                    break;
                case 3:
                    return "Rock Star";
                    break;
                case 4:
                    return "Ninja";
                    break;
                case 5:
                    return "Jedi";
                    break;
                default:
                    return "Sith Lord";
                    break;


            }
           
        }
        public bool gotToMaxRank()
        {
            if (rank == "Jedi")
                return true;
            else
                return false;
        }
        private void addLevel()
        {
            this.level++;
            setRank();
        }
        public void programCorrect()
        {
            addLevel();
        }
        public void helpedPeer()
        {
            addLevel();
            addLevel();
        }
        public void print()
        {
            Console.WriteLine("Ninja: " + name + " is rank " + rank + ", and level " + level);
        }

    }
}
