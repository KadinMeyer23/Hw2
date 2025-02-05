using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCannon
{
    public class Warning
    {


        public void warner() {

            for (int i = 1; i <= 100; i++) {
                int j = i % 3;
                int h = i % 5;
                if (j == 0 && h == 0) {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(i + ":Combined Blast");
                }
                else if (j == 0) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(i + ":Fire"); }
                else if (h == 0) {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(i + ":Electric"); }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(i +":Normal"); }
             
            
            
            }





        }





    
    }
}
