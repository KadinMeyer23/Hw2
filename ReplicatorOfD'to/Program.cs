namespace ReplicatorOfD_to
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Replicator>ListOfReplicates = new List<Replicator>();
            Replicator arep = new Replicator();
            ListOfReplicates.Add(arep);
            arep.ArrayMuli();
        }
    }
}
