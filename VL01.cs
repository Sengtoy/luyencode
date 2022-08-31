using System;
namespace VL01{
public class Program
{
    static void Main(string[] args)
    {
       string s1 = Console.ReadLine();
            var s2 = s1.Split(' ');
            int a = Convert.ToInt32(s2[0]);
            int b = Convert.ToInt32(s2[1]);
            for (int i = a; i <= b; i++)    
            Console.Write("{0} ", i);
    }
}
