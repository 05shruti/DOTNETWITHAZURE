using System;

public class Class1
{
    static int maxCHARS = 256;
    static void calculate(string s, int[] cal)
    {
        for (int i = 0; i < s.Length; i++)
            cal[s[i]]++;
    }
    public static void Main()
    {
        string s = "aabbcccdddeee";
        int[] cal = new int[maxCHARS];
        calculate(s, cal);
        for (int i = 0; i < maxCHARS; i++)
            if (cal[i] > 1)
            {
                Console.WriteLine("Character" + (char)i);
                Console.WriteLine("Occurence =" + cal[i] + "times");
            }
    }
}