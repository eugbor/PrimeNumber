using System;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var ob = new Number();
            for (int i = 2; i <= n; i++)
            {
                if(ob.IsPrime(i) != -1)
                Console.WriteLine(ob.IsPrime(i));
            }
            Console.ReadLine();
        }
    }
}
