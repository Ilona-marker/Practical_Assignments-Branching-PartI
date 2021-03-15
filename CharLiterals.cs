using System;
 class CharLiterals 
  {
  // Main Method 
    public static void Main(String[] args)
    {
     // character literal within single quote 
     char ch = 'a';
     // Unicode representation 
     char c = '\u0061';
      Console.WriteLine(ch); 
      Console.WriteLine(c);
      // Escape character literal 
      Console.WriteLine("Hello\n\nWorld\t!");
   }
}