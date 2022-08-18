using System;

namespace _005_out_immersive
{
    class Example
    {
        public string Name {get; set;}
        public int Age {get; set;}

        Example(string name,int age, out string test)
        {
            this.Name = name;
            this.Age = age;
            test = "testing.."
        }
    }
}
