using System;

namespace _004_required
{
    class ID
    {
       // public ID() {}

        public Guid Id {get; set;} = Guid.NewGuid();
        public required string Name {get; set;}
        public required int Number {get; set;}

        [SetsRequiredMembers]
        public ID(string name, int number)
        {
            this.Name = name;
            this.Number = number;
        }
    }
}