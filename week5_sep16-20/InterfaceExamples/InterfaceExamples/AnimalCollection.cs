using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExamples
{
    public class AnimalCollection : ICollection<IAnimal>
    {
        private List<IAnimal> _animals = new();

        public uint LegCount
        {
            get
            {
                uint count = 0;
                foreach (IAnimal a in _animals)
                {
                    count += a.Legs;
                }

                return count;
            }
        }

        public int Count => _animals.Count;

        public bool IsReadOnly => false;

        public void Add(IAnimal item)
        {
            _animals.Add(item);
        }

        public void Clear()
        {
            ((ICollection<IAnimal>)_animals).Clear();
        }

        public bool Contains(IAnimal item)
        {
            return ((ICollection<IAnimal>)_animals).Contains(item);
        }

        public void CopyTo(IAnimal[] array, int arrayIndex)
        {
            ((ICollection<IAnimal>)_animals).CopyTo(array, arrayIndex);
        }

        public IEnumerator<IAnimal> GetEnumerator()
        {
            return ((IEnumerable<IAnimal>)_animals).GetEnumerator();
        }

        public bool Remove(IAnimal item)
        {
            return ((ICollection<IAnimal>)_animals).Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_animals).GetEnumerator();
        }
    }
}
