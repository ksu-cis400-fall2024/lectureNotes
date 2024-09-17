using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public uint Legs { get; set; } = 4;

        public string Name { get; init; }

        public uint Age { get; set; } = 0;

        //add PeopleYears property
        //0 dog -> 0 person
        //1 dog -> 15 person
        //2 dog -> 24 person
        //3 dog -> 29 person
        //4 dog -> 34 person
        //5 dog -> 39 person
        //etc.

        public uint PeopleYears
        {
            get
            {
                if (Age == 0) return 0;
                else if (Age == 1) return 15;
                else if (Age == 2) return 24;
                else return 29 + 5 * (Age-3);
            }
        }
    }
}