using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public struct PointStruct
    {
        public int X { get;  }
        public int Y { get; }

        public PointStruct(int x, int y)
        {
            X = x;
            Y = y;
        }

        //make a Print method
        public void Print()
        {
            Console.WriteLine($"({X}, {Y})");
        }
    }
}
