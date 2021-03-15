using System;
 public class Date
{
  public static void Main()
   {
       Console.Write("Please write the year: ");
         int year = Int32.Parse(Console.ReadLine()); //Converts the string representation of                                                     
         if (year < 0 || year > 2021 ) {              //of this instance as specified by format.     
             Console.WriteLine("Error!Bad year information provided.");
             return;         
         }                       
        Console.Write("Please write the month: "); 
         int month = Int32.Parse(Console.ReadLine()); 
         if (month < 1 || month > 12) {
             Console.WriteLine("Error!Bad month information provided.");
             return;
         }                                     
        Console.Write("Please write the day: ");  
       int day = Int32.Parse(Console.ReadLine());  
         if (day < 1 || day > 31 || (month ==2 && day > 28) ||
            (month == 4 || month == 6 || month == 9 || month == 11 && day > 30)) {
         Console.WriteLine("Error!Bad day information provided.");
             return;       
         }
         Console.Write("What format do you want to print out the date?\n");
         Console.Write("Please select the date formatting.\n");
         Console.Write("1 - YYYY/MM/DD, 2- YYYY.MM.DD\n");
         int TypeOfDate = Int32.Parse(Console.ReadLine()); 
         char separator = ' ';
         if ( TypeOfDate == 1) {
             separator = '/';
         } else if ( TypeOfDate == 2) {
             separator = '.';
         }
             Console.WriteLine($"Your date is {year.ToString("0000")}{separator}{month.ToString("00")}{separator}{day.ToString("00")}");
         }
      }
   
