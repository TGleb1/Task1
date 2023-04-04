using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n <= 2)
            {
                if (n == 1)
                {
                    return 1;
                }
                if (n == 2)
                {
                    return 2;
                }
            }
            int[] array = new int[n];
            array[1] = 2;
            array[2] = 3;
            for (int i = 3; i <= n - 1; i++)
            {
                array[i] = array[i - 1] + array[i - 2];
            }
            return array.Max();
        }
    }
}
