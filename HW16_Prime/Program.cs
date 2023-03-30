using System.Collections.Concurrent;

namespace HW16_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new ConcurrentBag<int>();
            Parallel.For(0, int.Parse(Console.ReadLine()), i =>
            {
                if (IsPrime(i)) arr.Add(i);
            });
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static bool IsPrime(int n)
        {
            if (n < 2)
                return false;
            if (n < 4)
                return true;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}