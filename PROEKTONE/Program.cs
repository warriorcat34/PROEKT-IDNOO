namespace PROEKTONE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M, R;

            do
            {
                Console.Write("DAI CHISLO M: ");
                M = int.Parse(Console.ReadLine());
                Console.Write("DAI CHISLO R: ");
                R = int.Parse(Console.ReadLine());
            } while (M < 1 || M > 100 || R < 1 || R > 100);

            List<int> numbers = new List<int>();

            if (M < R)
            {
                for (int i = M; i <= R; i++)
                {
                    numbers.Add(i);
                }
            }
            else
            {
                for (int i = R; i <= M; i++)
                {
                    numbers.Add(i);
                }
            }

            numbers = numbers.OrderBy(n => n).ToList();

            Console.WriteLine($"Chetnite chisla sa: {string.Join(", ", numbers.Where(n => n % 2 == 0))}");
            Console.WriteLine($"Chislata, koito se delqt na 3 sa: {string.Join(", ", numbers.Where(n => n % 3 == 0))}");
            Console.WriteLine($"Sredno-Aritmetichno na chislata e: {numbers.Average()}");
            Console.WriteLine($"Broqt na polojitelnite chisla v diapazona e: {numbers.Count}");
        }
    }
    
}
