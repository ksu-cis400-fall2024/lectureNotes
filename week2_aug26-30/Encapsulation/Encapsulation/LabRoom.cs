using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class LabRoom
    {
        //only allow 10-30 computers
        private uint _computers = 20;
        public uint Computers
        {
            get => _computers;
            set
            {
                if (value >= 10 && value <= 30)
                {
                    _computers = value;
                }
            }
        }

        public bool Windows { get; } = true;

        public static bool DrinksAllowed { get; set; } = false;

        public LabRoom(bool isWindows)
        {
            Windows = isWindows;
        }
    }
}
