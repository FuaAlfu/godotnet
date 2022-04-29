using System;

namespace _000_a
{
public class MainOne 
{
    private string _mark;
    private string _name; //filed
    public string Name //property
     {
    get { return _mark; }   // get method
    set { _mark = value; }  // set method
     }
   // Person p1 = new Person();

  //constructing..
     public MainOne(string name)
   {
      this._name = name;
   }

   public string NameShow => $"{_name}";

}

// struct Person
// {
//    private string Name;
//    private int Age; 

//  public string SetName(string name)
//    {
//        this.Name = name;
//    }
//    public int SetAge(int age)
//    {
//        this.Age = age;
//    }
// }

    // internal record struct NewStruct(name Item1, object Item2)
    // {
    //     public static implicit operator (name, object)(NewStruct value)
    //     {
    //         return (value.Item1, value.Item2);
    //     }

    //     public static implicit operator NewStruct((name, object) value)
    //     {
    //         return new NewStruct(value.Item1, value.Item2);
    //     }
    // }
}