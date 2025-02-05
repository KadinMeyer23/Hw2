using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplicatorOfD_to
{
    public class Replicator
    {


        public int ArrayMuli() {

            int length = 5; 
            int[] array = new int[length];
            Console.WriteLine("Enter Your 5 Values: ");
            for (int index = 0; index < array.Length; index++)
                array[index] = Convert.ToInt32(Console.ReadLine());

            int[] array2 = new int[length];
            for (int index = 0; index < array.Length; index++)
            {
                array2[index] = array[index];
            }
            Console.WriteLine("Printing Array 1: ");
            for (int index = 0; index < array.Length; index++)
                Console.WriteLine(array[index]);

            Console.WriteLine("Printing Array 2: ");
            for (int index = 0; index < array2.Length; index++)
                Console.WriteLine(array2[index]);



            return 0;
        }

    }
}
