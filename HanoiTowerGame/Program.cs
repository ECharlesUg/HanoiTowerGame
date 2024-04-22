namespace HanoiTowerGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Test Disc Class
            //Disc d1 = new Disc(1);
            //Disc d2 = new Disc(2);
            //Disc d3 = new Disc(3);
            //Console.WriteLine(d1);
            //Console.WriteLine(d2);
            //Console.WriteLine(d3);

            //// Test Tower Class
            //Stack<int> discs1 = new Stack<int>([1, 2, 3]);
            //Stack<int> discs2 = new Stack<int>([5, 4, 3, 2, 1]);
            //Stack<int> discs3 = new Stack<int>([5, 2, 1]);

            //Tower t1 = new Tower(discs1, discs1.Count + 2, "A");
            //Tower t2 = new Tower(discs2, discs2.Count + 2, "B");
            //Tower t3 = new Tower(discs3, discs3.Count + 2, "C");

            //Console.WriteLine(t1);
            //Console.WriteLine(t2);
            //Console.WriteLine(t3);

            //---------------- Test the Game -----------------------------------------------------------

            TowerSet hanoiTower = new TowerSet(5);
            hanoiTower.PrintTowers();
            while (true)
            {
                string? input = String.Empty;

                Console.Write("> Move disk from tower: ");
                input = Console.ReadLine();
                char fromTower = input[0];

                Console.Write("> Move disk to tower: ");
                input = Console.ReadLine();
                char toTower = input[0];

                Console.Clear();
                hanoiTower.Move(fromTower, toTower);
                hanoiTower.PrintTowers();
            }
        }
    }
}
