using HackerrankPractice.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankPractice.Recurrsion
{
    class DavisStairCase : BaseSolution
    {
        private Dictionary<int, int> ways = new Dictionary<int, int>();

        public override void Execute()
        {
            int stairs = 0;
            Console.WriteLine("Please Enter number of stairs");
            stairs = int.Parse(Console.ReadLine());
            Console.WriteLine("Number of ways = " + stepPerms(stairs));
            this.Quit();
        }

        private int stepPerms(int n)
        {
            if (ways.ContainsKey(n))
            {
                return ways[n];
            }

            if (n == 0)
            {
                return 1;
            }

            if (n < 0)
            {
                return 0;
            }

            int oneWays = stepPerms(n - 1);
            int twoWays = stepPerms(n - 2);
            int threeWays = stepPerms(n - 3);
            //doing this as DP strategy to save time in larger operations
            ways.Add(n, oneWays + twoWays + threeWays);

            return oneWays + twoWays + threeWays;
        }
    }
}
