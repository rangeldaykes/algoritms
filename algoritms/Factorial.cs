using System;

namespace algoritms
{
    public class Factorial
    {
        public int Factorial_With_For(int num)
        {
            var fact = 1;
            for (int i = num; i > 0; i--)
            {

                fact *= i;                
            }

            return fact;
        }

        public int Factorial_With_While(int num)
        {
            var fact = 1;
            var count = num;
            while (count > 0)
            {
                fact *= count;
                count -= 1;
            }

            return fact;
        }

        public int Factorial_With_Recursive(int num)
        {
            if (num == 1)
                return 1;

            return num * Factorial_With_Recursive(num-1);
        }
    }
}
