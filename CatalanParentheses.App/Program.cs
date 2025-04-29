using System;

namespace CatalanParentheses.App
{
    public class CatalanCalculator
    {
        public static int CountWellFormedParenthesis(int n)
        {
            if (n <= 0)
                return 0;
            int[] dp = new int[n + 1];
            dp[0] = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    dp[i] += dp[j] * dp[i - j - 1];
                }
            }
            return dp[n];
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("n = 5");
            int result = CatalanCalculator.CountWellFormedParenthesis(5);
            Console.WriteLine($"Количество комбинаций: {result}");
        }
    }
}