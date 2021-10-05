using System;

namespace SumOfNumbers
{
 class Program
 {
  static void Main(string[] args)
  {
   System.Console.WriteLine("Enter first number");
   int a = Convert.ToInt32(System.Console.ReadLine());
   System.Console.WriteLine("Enter second number");
   int b = Convert.ToInt32(System.Console.ReadLine());
   int total = Sum(a, b);
   System.Console.WriteLine("sum of {0} and {1} is {2}", a, b, total);

  }
  static int Sum(int a, int b)
  {
   return a + b;
  }



 }
}
