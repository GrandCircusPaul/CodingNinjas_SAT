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
            //Run3(); //Adam Ashley Mara Uma

            //Run4(); //Shamseen, Greg, Nile, Mahmood
            Console.ReadLine();
        }

        static void Run4() //Student.cs
        {
            //creating a list of students
            List<Student> team = new List<Student>();

            //adding to team based on user input
            makeTeam(team); 
        }

        //populate list based on user input
        static void makeTeam(List<Student> team)
        {
            int size = 0, level = 0;
            string name = "";

            //asking how large user wants team to be
            Console.Write("How many students do you want to add? >>");

            //error-handling
            while (!Int32.TryParse(Console.ReadLine(), out size) || size <= 0)
                Console.WriteLine("Invalid input, please enter a positive integer for team size: ");

            Console.Clear();

            //setting input as the limiter for team
            //asking for name and level of each student
            for (int i = 0; i < size; i++)
            {
                //asking name
                Console.Write("\nEnter student #{0}'s name: ", i + 1);
                name = Console.ReadLine();

                //asking level
                Console.Write("Enter student #{0}'s level (integer number): ", i + 1);

                //error-handling
                while (!Int32.TryParse(Console.ReadLine(), out level) || level < 0)
                    Console.Write("Invalid input, please enter a positive integer for student's level: ");

                team.Add(new Student(name, level)); //instantiating new member
            }

            Console.Clear();
            Console.WriteLine("This is your new team!");
            foreach (Student s in team)
                s.print();
        }

        //menu of options for user to modify students
        static char menu(List<Student> team)
        {
            char input = 'Z';

            return input;
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
