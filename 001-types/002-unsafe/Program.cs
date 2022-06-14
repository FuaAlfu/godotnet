using System;

namespace _002_unsafe
{
   internal unsafe class Program {  
    private static void Main() {  
        unsafe {  
            int a = 20;  
  
            int * ptr = & a;  
  
            int * ptrptr2 = ptr;  
            Console.WriteLine($ "Value of a is {*ptr}");  
            Console.WriteLine($ "Address of a is {(int)ptr2}");  
        }  
    }  
} 
}
