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

        //gets and sets
        public int Category { 
            get { return category; }
            set { this.category = value; }
        }
        //Constructor

        public Shop(int aItem) {
        Category = aItem;
        
        }

        //Methods
        public void GetCategory() {
            switch (Category)
            {
                case 1:
                    Console.WriteLine("Rope : 10 Coins");
                    break;
                case 2:
                    Console.WriteLine("Torches : 15 Coins");
                    break;
                case 3:
                    Console.WriteLine("Climbing Equipment : 45 Coins");
                    break;
                case 4:
                    Console.WriteLine("Clean Water : 3 Coins");
                    break;
                case 5:
                    Console.WriteLine("Machete : 12 Coins");
                    break;
                case 6:
                    Console.WriteLine("Canoe : 100 Coins");
                    break;
                case 7:
                    Console.WriteLine("Food Supplies : 16 Coins");
                    break;
                default:
                    Console.WriteLine("Apologies. I do not know that one.");
                    break;
            }



            
        }
    }
}
