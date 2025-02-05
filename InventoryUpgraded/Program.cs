//Written By Kadin Meyer
// 2/4/2025

using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System;

namespace BuyingInventory
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The following items are available:\n 1 – Rope \n 2 – Torches\n 3 – Climbing Equipment\n 4 – Clean Water\n 5 – Machete \n 6 – Canoe\n 7 – Food Supplies\n What number do you want to see the price of?");
            int item = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User Name");
            string name = Convert.ToString(Console.ReadLine());

            List<Shop> listOfItems = new List<Shop>();
            Shop ashop = new Shop(item,name);
            listOfItems.Add(ashop);
            ashop.GetCategory();
        }
    }
}