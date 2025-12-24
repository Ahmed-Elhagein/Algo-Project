using System;

class LongestRepeatedSubstringDP
{
    static int LRS(string s)
    {
        int n = s.Length;
        int[,] dp = new int[n + 1, n + 1];
        int maxLen = 0;

        for (int i = 1; i <= n; i++)
        {
            for (int j = i + 1; j <= n; j++)
            {
                if (s[i - 1] == s[j - 1])
                {
                    dp[i, j] = dp[i - 1, j - 1] + 1;
                    maxLen = Math.Max(maxLen, dp[i, j]);
                }
                else
                {
                    dp[i, j] = 0;
                }
            }
        }

        return maxLen;
    }

    static void Main()
    {
        Console.WriteLine(LRS("banana"));   // 3
        Console.WriteLine(LRS("aabaaba")); // 4
    }
}
