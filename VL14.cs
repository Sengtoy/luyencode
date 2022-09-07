using System;
namespace VL14{
class Program {
  static void Main(string[] args) {
            string s = Console.ReadLine();
            var s1 = s.Split(' ');
            int a = Convert.ToInt32(s1[0]);
            int b = Convert.ToInt32(s1[1]);
            int c= UCLN(a,b);
            Console.WriteLine(c);
             Console.ReadLine();
  }
             static int UCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0) return a;
            return UCLN(b, a % b);
        }
    }
}