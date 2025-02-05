using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrototype
{
    public class Proto
    {
        //private variables
        private int user1 = -1;
        private int user2 = -1;

        //gets and sets

        public int User1 {
            get { return user1; } set { user1 = value; }
        }

        public int User2 { 
            get { return user2; } set { user2 = value; } 
        }
        //Constructor

        public Proto(int aUser1, int aUser2) {
            User1 = aUser1;
            User2 = aUser2;
        }


        //Methods
        public void guesser() {

            while (User1 != User2) {



                Console.WriteLine("Enter Guess: ");
                User2 = Convert.ToInt32(Console.ReadLine());


                if (User2 > User1) { Console.WriteLine("You're Too High"); }
                else if (User2<User1){ Console.WriteLine("You're too Low"); }
            
            }
            if (User1 == User2) { Console.WriteLine("You Guessed It!!"); }
        
        }

    }
}
