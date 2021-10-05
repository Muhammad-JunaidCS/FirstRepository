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

  static float Sum(float a, float b)
  {
   return a + b;
  }

  static float SquaredSum(float a, float b)
  {
   return ((a * a) + (b * b));
  }

  static float SumOfThreeNumbers(float a,float b,float c)
  {
   return a + b + c;
  }

  static float SquaredSumOfTwoNumsMinusThirdNum(float a , float b, float c)
  {
   return ((a * a) + (b * b)) - c;
  }

  static float SumOfTwoNumsMinusThirdNum(float a,float b,float c)
  {
   return (a + b) - c;
  }
 }
}
