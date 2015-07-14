using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppl_Day6_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            List<Ninjas> squad = new List<Ninjas>();
            
            do
            {
                Console.WriteLine("Please enter the name of a student.");
                squad.Add(new Ninjas(Console.ReadLine()));
                Console.WriteLine("Press enter to add another student or press any key then enter to move forward.");//pressing any key other than <Enter> exits the loop because 'while' condition is met
                str = Console.ReadLine();
            } while (string.IsNullOrEmpty(str));//check if string is empty (pressing <Enter>) and if so loop again

            for (int x = 0; x < squad.Count(); x++ )
            {
                Console.WriteLine("{0} Please enter the number of programs you've completed.", squad[x].Name);//get
                int prog = int.Parse(Console.ReadLine());

                squad[x].levelUp(prog);

                Console.WriteLine("{0} Please enter the number of people you've helped.", squad[x].Name);//get
                prog = int.Parse(Console.ReadLine()) * 2;

                squad[x].levelUp(prog);
            }
            for (int x = 0; x < squad.Count(); x++ )
            {
                squad[x].print();
            }
        }
    }

    class Ninjas
    {
        public string Name { get; set; }
        int level = 0;
        string rank;
       
        public Ninjas(string n)
        {
            rank = "Beginner";
            level = 0;
            Name = n;//set

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

