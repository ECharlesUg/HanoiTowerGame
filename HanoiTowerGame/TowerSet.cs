using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HanoiTowerGame
{
    internal class TowerSet
    {
        public Tower[] Towers; // The 3 towers are stored in Towers.
        public int N; // the total number of discs the game has.
        public static readonly Dictionary<char, int> TowerIndex = new Dictionary<char, int>
        {
            // A dictionary to map the Tower Label to it's proper index in Towers variable.
            {'A', 0 },
            {'a', 0 },
            {'B', 1 },
            {'b', 1 },
            {'C', 2 },
            {'c', 2 },
        };
       
        public TowerSet(int n)
        {
            N = n;
           Towers = new Tower[3]; //create an array of 3 towers
           Towers[0] = new Tower(new Stack<int>(Enumerable.Range(1, n).Reverse()), n,"A"); // when tower A with n number of discs
           Towers[1] = new Tower(new Stack<int>(), n, "B"); // when tower B is empty
           Towers[2] = new Tower(new Stack<int>(), n, "C"); // when tower C is empty

        }

        public void PrintTowers()
        {
            for (int i = N; i > 0; i--)
            {
                string levelOutput = String.Empty;
                for (int j = 0; j<3; j++)
                {
                    levelOutput += Towers[j].GetDisc(i) + "   ";
                }
                Console.WriteLine(levelOutput);
            }
            for (int i = 0; i < 3; i++)
            {
                Console.Write(Towers[i].GetBase() + "   ");
            }
            Console.WriteLine();
            for (int i = 0;i < 3; i++)
            {
                Console.Write(Towers[i].GetLabel()+ "   ");
            }
        }
        public void PrintVertically()
        {
            for (int j = 0; j < 3; j++)
            {
                string levelOutput = String.Empty;
                for (int i = N; i > 0; i--)
                {
                    Console.WriteLine(Towers[j].GetDisc(i) + "  ");
                }
                Console.WriteLine(Towers[j].GetBase() + "  ");
                Console.WriteLine(Towers[j].GetLabel());
            }
        }

        public void Move(char towerA, char towerB)
        {
            // check when tower A and tower B are valid
            
            if(!TowerIndex.ContainsKey(towerA) || !TowerIndex.ContainsKey(towerB))
            {
                Console.WriteLine("Invalid tower");
                return;
            }

            int indexA = TowerIndex[towerA];
            int indexB = TowerIndex[towerB];


            // check if they are the same tower
            if (indexA == indexB)
            {
                Console.WriteLine("cannot move");
                return;
            }

            if(Towers[indexA].Discs.Count == 0)
            {
                Console.WriteLine("Tower a is empty");
                return;
            }
            // check if both towers are empty
            if (Towers[indexB].Discs.Count == 0) 
            {
                // id tower b is empty move disc from towerA to b

                int discToMove = Towers[indexA].Discs.Pop();
                Towers[indexB].Discs.Push(discToMove);
                Console.WriteLine($"Moved disc {discToMove} from tower {towerA} TO TOWER {towerB}");
            }
            else
            {
                // check if towera moved a bigger disk to a smaller one

                int topDiscA = Towers[indexA].Discs.Peek();
                int topDiscB = Towers[indexB].Discs.Peek();


                if(topDiscA> topDiscB)
                {
                    Console.WriteLine($"Cannot move disc {topDiscA} to tower {towerB} because its smaller");
                    return;
                }

                // if disc from towera is smaller or equal to the disk at the top pf tower B

                int discToMove = Towers[indexA].Discs.Pop();
                Towers[indexB].Discs.Push(discToMove );
                Console.WriteLine("Moved disk form tower to anoter");
            }

        }
    }
}
