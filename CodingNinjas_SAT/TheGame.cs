using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingNinjas_SAT
{
    class TheGame
    {
        int level;
        
        public TheGame()
        {
            level = 0;
        }

        public void Greeting()
        {
            Console.WriteLine("Welcome code crusader!");
        }
        
        public void adventure()
        {
            do
            {
                Console.WriteLine("Would you like to Complete the project alone or with a friend?");
                Console.WriteLine("Type 1 to program alone type two to program with a friend");
                level = IncrementLevel(int.Parse(Console.ReadLine()), level);
                Console.WriteLine();
            } while (level <= 26);
        }
        
        public int IncrementLevel ( int choice, int level)
        {
            if (choice == 1)
            {
                level++;
            }
            else if(choice == 2)
            {
                level++;
                level++;
            }
            rank(level);
            return level;
        }
        
        public void rank(int rankInteger)
        {
            switch (rankInteger / 5)
            {
                case 0:
                    {
                        Console.WriteLine("Congrats! you are now level" + rankInteger + "beginner rank developer");
                        break;
                    }
                case 1:
                    {
                        Console.WriteLine("Congrats! you are now level" + rankInteger + "Grasshopper rank developer");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Congrats! you are now level" + rankInteger + "Journeyman rank developer");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Congrats! you are now level" + rankInteger + "RockStar rank developer");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Congrats! you are now level" + rankInteger + "Ninja rank developer");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Congrats! you are now level" + rankInteger + "Jedi rank developer");
                        break;
                    }
                default :
                    {
                        Console.WriteLine("Something went wrong!");
                    }
                break;
            }
        }
    }
}
