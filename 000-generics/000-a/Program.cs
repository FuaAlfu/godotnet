using System;
using System.Collections.Generic;

namespace _000_a
{
    class Program
    {
        static void Main(string[] args)
        {
           MyGenericType<int> intArray = new MyGenericType<int>(5);

           //setting values
         for (int c = 0; c < 5; c++) 
         {
            intArray.setItem(c, c*5);
         }
         
         //retrieving the values
         for (int c = 0; c < 5; c++) 
         {
            Console.Write(intArray.getItem(c) + " ");
         }
         
         Console.WriteLine();
         
         //declaring a character array
         MyGenericType<char> charArray = new MyGenericType<char>(5);
         
         //setting values
         for (int c = 0; c < 5; c++) 
         {
            charArray.setItem(c, (char)(c+97));
         }
         
         //retrieving the values
         for (int c = 0; c< 5; c++) 
         {
            Console.Write(charArray.getItem(c) + " ");
         }
         Console.WriteLine();
         
         Console.ReadKey();
        }
    }
}
