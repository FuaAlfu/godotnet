using System;

namespace _000_a
{
    class Program
    {
        static void Main(string[] args)
        {
           MainOne mainOne = new MainOne("mainOne");
           Console.WriteLine(mainOne);
          mainOne.Name = "markdown..";
          Console.WriteLine(mainOne.Name);

       // System.Console.WriteLine("Hello");
        }
    }
}
