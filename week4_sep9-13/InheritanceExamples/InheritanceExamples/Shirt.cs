using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExamples
{
    public abstract class Shirt
    {
        public Color ShirtColor { get; init; } = Color.Black;

        protected uint _quantity;

        public abstract uint Quantity { get; set; }

        protected decimal _baseCost;

        public decimal Price => _baseCost * Quantity;
    }
}
