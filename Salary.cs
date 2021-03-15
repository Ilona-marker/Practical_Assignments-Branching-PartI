using System;
 public class Salary
{
  public static void Main(string[] args)
  {
      Console.Write("Please write working hours in day: "); 
      int workingHoursInDay = Int32.Parse(Console.ReadLine());
      if (workingHoursInDay < 0 || workingHoursInDay > 24 ) {
          Console.WriteLine($"It is not possible to work {workingHoursInDay} hours in a day");
      }

          else {
              int rate = 10;
              decimal Salary = Math.Min(workingHoursInDay,8) * rate + Math.Max(workingHoursInDay-8,0) * rate * 1.5m;
              Console.WriteLine($"The salary is {Salary.ToString("0.00")} Euro in a day.");
          }
    }
}




