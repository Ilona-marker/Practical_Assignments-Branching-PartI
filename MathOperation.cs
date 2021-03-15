using System;
  namespace MathOperators
   {
    class MathOperation
    {
      // Main Method
     public static void Main(String[] args)
      {

        int x = 15;
        int y = 10;
        // Max and Min methods
         Console.WriteLine(Math.Max(x, y)); // will print max value, that is 7
         Console.WriteLine(Math.Min(x, y)); // will print max value, that is 3
         // Absolute and Round methods
         Console.WriteLine(Math.Abs(-5.9)); // will print absolute value, that is 5.9
         Console.WriteLine(Math.Round(-5.9)); // will print rounded value, that is -6
         //Try other methods from the prevous slide on your own
         Console.WriteLine("Press Enter Key to Exit..");
         Console.ReadLine();
       }
     }
   }

