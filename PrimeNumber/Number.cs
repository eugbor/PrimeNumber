namespace PrimeNumber
{
    class Number
    {
        public int IsPrime(int x)
        {
            for (int i = 2; i <= x/i; i++)
                if ((x % i) == 0) return -1;
            return x;
        }
    }
}
