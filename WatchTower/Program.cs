//Written By Kadin Meyer
// 2/4/2025

namespace WatchTower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter X Coordinate: ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y Coordinate: ");
            int Y = Convert.ToInt32(Console.ReadLine());



            List<DefenseTower>ListOfDefenses = new List<DefenseTower>();
            DefenseTower aDefense = new DefenseTower(X,Y);
            ListOfDefenses.Add(aDefense);
            aDefense.Defense();

            
        }
    }
}
