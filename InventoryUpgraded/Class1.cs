//Written By Kadin Meyer
// 2/4/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyingInventory
{
    public class Shop
    {
        //variables
        private int category = -1;
        private string name = "n/a";

        //gets and sets
        public int Category
        {
            get { return category; }
            set { this.category = value; }
        }

        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }
        //Constructor

        public Shop(int aItem, string aName)
        {
            Category = aItem;
            Name = aName;

        }

        //Methods
        public void GetCategory()
        {
            switch (Category)
            {
                case 1:
                    
                    if (Name == "Kadin") { Console.WriteLine("Rope : 5 Coins"); }
                    else { Console.WriteLine("Rope : 10 Coins"); }
                    break;
                case 2:
                    if (Name == "Kadin") { Console.WriteLine("Torches : 7.5 Coins"); }
                    else { Console.WriteLine("Torches : 15 Coins"); }
                    break;
                case 3:
                    if (Name == "Kadin") { Console.WriteLine("Climbing Equipment : 22.5 Coins"); }
                    else { Console.WriteLine("Climbing Equipment : 45"); }
                    break;
                case 4:
                    if (Name == "Kadin") { Console.WriteLine("Clean Water : 1.5 coins"); }
                    else { Console.WriteLine("Clean Water : 3 coins"); }
                    break;
                case 5:
                    if (Name == "Kadin") { Console.WriteLine("Machete : 6 Coins"); }
                    else { Console.WriteLine("Machete : 12 Coins"); }
                    break;
                case 6:
                    if (Name == "Kadin") { Console.WriteLine("Canoes : 50 Coins"); }
                    else { Console.WriteLine("Canoes : 100 Coins"); }
                    break;
                case 7:
                    if (Name == "Kadin") { Console.WriteLine("Food Supplies : 8 Coins"); }
                    else { Console.WriteLine("Food Supples : 16 Coins"); }
                    break;
                default:
                    Console.WriteLine("Apologies. I do not know that one.");
                    break;
            }




        }
    }
}