namespace algoritms
{
    public class Fibonacci
    {
        public int[] Fibonacci_With_For(int fib)
        {
            var ret = new int[fib];
            ret[0] = 0;
            ret[1] = 1;

            for (int i = 2; i < fib; i++)
            {
                ret[i] = ret[i - 1] + ret[i - 2];
            }

            return ret;
        }

        public int[] Fibonacci_With_For2(int fib)
        {
            var ret = new int[fib];

            for (int i = 0; i < fib; i++)
            {
                if (i == 0)
                {
                    ret[i] = 0;
                }
                else if (i == 1)
                {
                    ret[i] = 1;
                }
                else if (i >= 2)
                {
                    ret[i] = ret[i - 1] + ret[i - 2];
                }
            }

            return ret;
        }
    }
}