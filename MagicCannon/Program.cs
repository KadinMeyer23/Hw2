namespace MagicCannon
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<Warning> listofwarnings = new List<Warning>();
            Warning awarning = new Warning();
            listofwarnings.Add(awarning);

            awarning.warner();
        }
    }
}
