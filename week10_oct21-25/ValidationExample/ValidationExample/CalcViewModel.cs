using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationExample
{
    public class CalcViewModel : INotifyPropertyChanged
    {

        private uint _shirts = 0;
        public uint Shirts
        {
            get => _shirts;
            set
            {
                _shirts = value;

                if (_shirts > 10)
                {
                    _shirts = 0;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Shirts)));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cost)));

                    throw new ArgumentException("too many shirts");
                }

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Shirts)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Cost)));

                //throw exception if #shirts is invalid (more than 10)

                //how to make sure cost is updated on GUI?
            }
        }

        public decimal Cost
        {
            get
            {
                if (Shirts <= 5) return Shirts * 10.00m;
                else return 5 * 10.00m + 8.00m * (Shirts - 5);
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
