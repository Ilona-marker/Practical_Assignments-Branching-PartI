using System;
 public class PowerMath
{
  public static void Main()
   {
     int a = 2;
     int b = 3;

     double aTob = Math.Pow(a, b);
     double bToa = Math.Pow(b, a);

       if (aTob == bToa)  {
           Console.WriteLine("Both are equal!");
       } else if (aTob > bToa) {
           Console.WriteLine($"{a} to the power of {b} is larger!");
       } else {
           Console.WriteLine($"{b} to the power of {a} is larger!");
       }
   }
}