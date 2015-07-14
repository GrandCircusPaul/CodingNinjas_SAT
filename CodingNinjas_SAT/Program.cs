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
            //Run1(); //Travis, Cheryl, Matthew, Hema 
           
            //Run2(); //Nasir Derrick Kevin Vaneitta 
            Run3(); //Adam Ashley Mara Uma
            Console.ReadLine();


        }

        static void Run3()//uses: "TheGame.cs"Adam Ashley Mara Uma
        {
            TheGame myAdventure = new TheGame();
            myAdventure.Greeting();
            myAdventure.adventure();
        }
        // uses: "CodingNinjas", "Team"
        static void Run1() 
        {
            string[] codeNames = { "Cold Shadows", "Cherydactyl", "Silent Death", "Sunny" };
            Team ourTeam = new Team(codeNames);
            int[] teamOrder = { 0, 1, 2, 3 };

            do
            {
                ourTeam.completeProjectByID(teamOrder);
                ourTeam.printTeamStatus();
            } while (!ourTeam.checkMaxTeamRank());
        }
        //Ninjas.cs
        static void Run2() 
        {
            string str = "";
            List<Ninjas> squad = new List<Ninjas>();

            do
            {
                Console.WriteLine("Please enter the name of a student.");
                squad.Add(new Ninjas(Console.ReadLine()));
                Console.WriteLine("Press enter to add another student or press any key then enter to move forward.");
                str = Console.ReadLine();
            } while (string.IsNullOrEmpty(str));

            for (int x = 0; x < squad.Count(); x++) 
            {
                Console.WriteLine("{0} Please enter the number of programs you've completed.", squad[x].Name);
                int prog = int.Parse(Console.ReadLine());

                squad[x].levelUp(prog);
                Console.WriteLine("{0} Please enter the number of people you've helped.", squad[x].Name);
                prog = int.Parse(Console.ReadLine()) * 2;
                squad[x].levelUp(prog);
            }
            for (int x = 0; x < squad.Count(); x++) 
            {
                squad[x].print();
            }
        }

    }
}
