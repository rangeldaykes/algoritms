using System.Collections.Generic;

namespace algoritms
{
    public class SumTwoNumberOfArray
    {
        public bool HasPairWithSum(int[] arr, int sum)
        {
            HashSet<int> comp = new HashSet<int>();

            foreach (int value in arr)
            {
                if (comp.Contains(value)) 
                    return true;

                comp.Add(sum - value);
            }

            return false;
        }


        // ToDo
        public int[] PairMatchingLinear(int[] arr, int value)
        {
            int ini = -1;
            int fim = -1;

            int low = 0;
            int hi = arr.Length - 1;

            while (low < hi)
            {
                int s = arr[low] + arr[hi];
                if (s == value)
                {
                    ini = arr[low];
                    fim = arr[hi];
                }
            }

            return new int[2] { ini, fim };
        }

        public int[] PairMatchingQuadratic(int[] arr, int value)
        {
            int ini = -1;
            int fim = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                int a = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int b = arr[j];
                    if (arr[i] + arr[j] == value)
                    {
                        ini = arr[i];
                        fim = arr[j];
                    }
                }
            }

            return new int[2] { ini, fim };
        }
    }
}