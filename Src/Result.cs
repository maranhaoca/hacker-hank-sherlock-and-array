using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'balancedSums' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static string balancedSums(List<int> arr)
        {
            if (arr.Count == 1)
            {
                return "YES";
            }

            int sum = arr.Sum();
            int left = 0;

            for (int i = 0; i < arr.Count - 1; i++)
            {
                //int left = arr.GetRange(0, i).Sum();
                if (i > 0)
                {
                    left += arr[i - 1];
                }

                int rigth = sum - left - arr[i];

                //int rigth = arr.GetRange(i + 1, arr.Count - i - 1).Sum();

                if (left == rigth)
                {
                    return "YES";
                }
            }

            return "NO";
        }
    }
}