using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class Dog : IAnimal, IComparable<Dog>
    {
        public string Sound()
        {
            return "Woof";
        }

        public int CompareTo(Dog? other)
        {
            return Name.CompareTo(other.Name);
        }

        public uint Legs { get; } = 4;

        public string Name { get; init; }

    }
}