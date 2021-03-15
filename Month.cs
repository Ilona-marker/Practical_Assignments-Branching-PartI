using System;
 public class Month
{
  public static void Main(string[] args)
   {
       Console.Write("Please write the day: "); 
       int day = Int32.Parse(Console.ReadLine());
             if (day <= 0) {
                Console.WriteLine("Error!Day is negative/Zero");
               return;
            }
             if (day > 365) {
                 Console.WriteLine("Error!It is the Next Year");
               return;
            }
            day -= 31;
            if (day <= 0) {
                 Console.WriteLine("Day belongs to January");
                 return;
            }
             day -= 28;
             if (day < 0) {
                  Console.WriteLine("Day belongs to February");
                  return;
             }
             day -= 31;
             if (day <= 0) {
                  Console.WriteLine("Day belongs to March");
                  return;
             } 
             day -= 30;
             if (day <= 0) {
                  Console.WriteLine("Day belongs to Apryl");
                  return;
             } 
             day -= 31;
             if (day <= 0) {
                 Console.WriteLine("Day belongs to Apryl");
                  return;
             } 
             day -= 30;
              if (day <= 0) {
                 Console.WriteLine("Day belongs to June");
                  return; 
              }
             day -= 31;
              if (day <= 0) {
              Console.WriteLine("Day belongs to July");
                  return;   
             } 
             day -= 31;
             if (day <= 0) {
                 Console.WriteLine("Day belongs to August");
                  return; 
             } 
             day -= 30;
              if (day <= 0 ) {
                Console.WriteLine("Day belongs to September");
                  return;  
             } 
             day -= 31;
              if (day <= 0) {
                 Console.WriteLine("Day belongs to October");
                  return; 
             }
             day -= 30;
              if (day <= 0) {
                 Console.WriteLine("Day belongs to November");
                  return;
              }
             day -= 31;
              if (day <= 0) {
                Console.WriteLine("Day belongs to December");
             }
        }
   }



       
