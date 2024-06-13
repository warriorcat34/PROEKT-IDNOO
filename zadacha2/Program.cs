using System.Threading.Channels;

namespace zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("disclaimer: Molq pishete chisla sus , sled tqh, Blagodarq! <33");
            double[] m = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();

            for (int i = 0; i < m.Length; i++) 
            {

                m.Where(m => m < 10);
               
                Console.WriteLine($"Chislo: {m[i]}");
            }


          //em sorry, tolkoz...
        }   
    }
}
