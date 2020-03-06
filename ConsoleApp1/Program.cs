using System;

namespace ConsoleApp1
{
   public  class Program
    {
       public static int Result(int d)
        {
            int k = d / 100;
            return k;
        }
       public static  int Result1(int d)
        {
            d %= 10;
            return d;
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter a three-digit number: ");
            int d = int.Parse(Console.ReadLine());
            int result = Result(d);
            int result1 = Result1(d);
            Console.WriteLine("The first num:" + result);
            Console.WriteLine("The last num:" + result1);
            Console.ReadKey();
        }
    }
}
