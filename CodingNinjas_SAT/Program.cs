using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingNinjas_SAT
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] codeNames = { "Cold Shadows", "Cherydactyl", "Silent Death", "Sunny" };
            Team ourTeam = new Team(codeNames);
            int[] teamOrder = { 0, 1, 2, 3 };

            do
            {
                ourTeam.completeProjectByID(teamOrder);
                ourTeam.printTeamStatus();
            } while (!ourTeam.checkMaxTeamRank());

            Console.ReadLine();

        }
    }
}
