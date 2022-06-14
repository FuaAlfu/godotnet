using System;
using System.Collections.Generic;

namespace _003_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
             	IDictionary<string, int> lich = new Dictionary<string, int>();
	 	lich.Add("One",22); 
	 	lich.Add("Three",33);
		
		foreach(KeyValuePair<string, int> kv in lich)
        {
            Console.WriteLine("the key: {0}, the value: {1}", kv.Key, kv.Value);
        }
		    Console.WriteLine("---");
	// 	more..
		var games = new Dictionary<string, string>(){
			{"Dark Souls","hope grif die live"},
			{"Elder Scroll","glitches, more glitches"},
		};

             foreach(var kv in games)
           {
               Console.WriteLine("the key: {0}, the value: {1}", kv.Key, kv.Value);
           }
          Console.ReadLine();
        }
    }
}
