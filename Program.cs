using System;

class LongestRepeatedSubstringNaive
{
    static int LRS(string s)
    {
        int n = s.Length;
        int maxLen = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int len = 0;

                // Compare characters starting from i and j
                while (i + len < n && j + len < n &&
                       s[i + len] == s[j + len])
                {
                    len++;
                }

                maxLen = Math.Max(maxLen, len);
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
