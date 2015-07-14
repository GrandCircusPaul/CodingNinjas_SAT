using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingNinjas_SAT
{
    class Student
    {
        //Shamseen, Mahmood, Greg, Nile
        public string name;
        public int level;
        string rank;

        //default constructor (we never use it)
        public Student()
        {
            level = 0;
            rank = "";
            name = "";
        }

        //overloaded constructor
        public Student (string id, int pts = 0) //addition as per Cheryl
        {
            name = id;
            level = pts;
            findRank(); //addition as per Paul
        }

        //increment level by action based on user input
        public void doSomething()
        {
            int action = 0;

            //asking user how they would like to modify student
            Console.Write("\nSelect a number: \nDid the student (1) Code a program,");
            Console.Write(" (2) Assist another student, or (3) Do nothing?\n>>");
            
            //error checking. if TryParse doesn't work, action == 0.
            action = 0;
            Int32.TryParse(Console.ReadLine(), out action);

            switch(action)
            {
                //student wrote a program
                case 1:
                    level++;
                    Console.WriteLine("Student's level has increased by one!");
                    break;
                 
                //student helped a peer
                case 2:
                    level += 2;
                    Console.WriteLine("Student's level has increased by two!!");
                    break;
                
                //user selected wrong student OR wanted to see everyone's stats.
                case 3:
                    return;

                default: Console.WriteLine("Invalid Number.\n"); break;
            }
        }

        //calculate rank based on level and printing a lil message with it
        private string findRank()
        {
            string msg = "";

            switch (level / 5)
            {
                case 0:
                    rank = "Beginner";
                    msg = "You are but a mere beginner still.";
                    break;

                case 1:
                    rank = "Grasshopper";
                    msg = "You are a fledgling grasshopper.";
                    break;

                case 2:
                    rank = "Journeyman";
                    msg = "You're a capable journeyman now!";
                    break;

                case 3:
                    rank = "Rock Star";
                    msg = "Looks like we have a programming rockstar on our hands!";
                    break;

                case 4:
                    rank = "Ninja";
                    msg = "What a programming ninja you are!";
                    break;

                case 5:
                    rank = "Jedi";
                    msg = "With you, the force is. You're a programming Jedi!";
                    break;
            }
            return msg;
        }
        
        //printing all info of student
        public void print()
        {
            string msg = findRank();

            Console.WriteLine("\n{0} is level {1} and rank {2}\n {3}", 
                name, level, rank, msg);
        }
    }
}
