using System;
class VL13
{
    static void Main()
    {
        string s = Console.ReadLine();
        int n = Convert.ToInt32(s);
        int sum = 0;
        for (int i = 1; i < n; i++)
            if (n % i == 0) sum += i;
        if (sum == n) Console.WriteLine("YES");
        else Console.WriteLine("NO");
    }
}