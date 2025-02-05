namespace ThePrototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User1 Enter Your Value: ");
            int User1 = Convert.ToInt32(Console.ReadLine());

            if (User1 > 100 || User1 < 0)
            {
                while (true)
                {
                    Console.WriteLine("User1 Enter Your Value: ");
                    User1 = Convert.ToInt32(Console.ReadLine());

                    if (User1 < 100 && User1 > 0) { break; }
                }
            }

            Console.Clear();



                List<Proto> ListofProto = new List<Proto>();
                Proto aproto = new Proto(User1, -1);
                ListofProto.Add(aproto);
                aproto.guesser();
            }
        }
    }
