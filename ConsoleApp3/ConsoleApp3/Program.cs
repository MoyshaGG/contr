using System;

namespace ConsoleApp3
{
    class Program
    {
       
        static void Main(string[] args)
        {
            char[] liter = { 'S', 'Y', 'M', 'B', 'O', 'L' };
            string bukv = new string(liter);
            Console.WriteLine(bukv);
            string string1 = bukv;
            int length;
            length = string1.Length;
            
            Console.WriteLine("літер - " + length);
           
            
          
            
            
            Console.ReadLine();

        }
    }
}
