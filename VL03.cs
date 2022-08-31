using System;
namespace VL03
{
    class Program
    {
        static void main(string[] args)
        {
           var s = Console.ReadLine();
            int n = Convert.ToInt32(s);
            int sum = 0;
            for(int i = 2; i <= n; i++)
                sum = sum + i;
            Console.WriteLine("{0}", sum);
            Console.ReadLine();  
        }
    }
}