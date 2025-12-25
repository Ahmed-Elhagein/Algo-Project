using System;

class LongestRepeatedSubstring
{
    // دالة حساب طول أطول سلسلة متكررة باستخدام البرمجة الديناميكية
    static int LRS(string s)
    {
        int n = s.Length;
        // إنشاء مصفوفة ثنائية لتخزين النتائج الفرعية
        int[,] dp = new int[n + 1, n + 1];
        int maxLen = 0;

        // ملء الجدول بناءً على مقارنة الأحرف
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                // الشرط: الأحرف متطابقة ولكن في مواقع مختلفة
                if (s[i - 1] == s[j - 1] && i != j)
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
        string input1 = "banana";
        string input2 = "aabaaba";

        Console.WriteLine($"String: {input1} -> LRS Length: {LRS(input1)}");   // Output: 3
        Console.WriteLine($"String: {input2} -> LRS Length: {LRS(input2)}"); // Output: 4
        
        // منع النافذة من الإغلاق فوراً
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
