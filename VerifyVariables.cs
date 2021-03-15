using System;
 public class VerifyVariables
{
  public static void Main()
  {
    int a = 45;
    int b = 66;
    /* Verify if there are any variables which are odd 
    (uneven, e.g. 1, 3, 5, 7 etc.). Print out information 
    in the console. ● Verify if there are any variables 
    which are even (e.g. 2, 4, 6, 8 etc.). 
    Print out information in the console*/
    if (a % 2 == 0 || b % 2 == 0 ) {
      Console.WriteLine("There are even values");
    } else if (a % 2 != 0 || b % 2 != 0 ) {
      Console.WriteLine("There are odd values");
    } else {
      Console.WriteLine("There are not any values");
    }
  }
}
   
    
  






