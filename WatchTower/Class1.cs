//Written By Kadin Meyer
// 2/4/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchTower
{
     public class DefenseTower
    {
        //Declare Class Variables
        private int x = -10000000;
        private int y = -10000000;

    //Gets and Sets
       public int X { get { return x; } set { x = value; } }
       public int Y { get { return y; } set { y = value; } }

        //empty Constructor
        public DefenseTower() : this(-1000, -2000) { }

        //Full constructor
        public DefenseTower(int aX, int aY) {
            X = aX;
            Y = aY;
        
        }
        
        
        //Methods
        public void Defense() {
            if (x < 0 && y > 0) { Console.WriteLine("They're Coming From NorthWest"); }
            else if (y == 0 && x < 0) { Console.WriteLine("They're coming from the West"); }
            else if (x < 0 && y < 0) { Console.WriteLine("They're coming from South West"); }
            else if (x == 0 && y > 0) { Console.WriteLine("They're coming from the North"); }
            else if (x == 0 && y == 0) { Console.WriteLine("They're Here!!!"); }
            else if (x == 0 && y < 0) { Console.WriteLine("They're coming from the South"); }
            else if (y > 0 && x > 0) { Console.WriteLine("They're Coming from the NorthEast"); }
            else if (y == 0 && x > 0) { Console.WriteLine("They're coming from the East"); }
            else if (y < 0 && x > 0) { Console.WriteLine("They're Coming from SouthEast"); }

        
        
        }

    }
}
