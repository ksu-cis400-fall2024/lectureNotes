using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Student
    {
        public string Name { get; }

        public string Major { get; }

        private List<int> _scores;

        public double Average
        {
            get
            {
                //derived property

                if (_scores.Count == 0) return 0;

                double sum = 0;
                foreach (int s in _scores)
                {
                    sum += s;
                }

                return sum / _scores.Count;
            }
        }

        public void AddScore(int score)
        {
            _scores.Add(score);
        }

        public Student(string n, string m)
        {
            Name = n;
            Major = m;
            _scores = new();
        }
    }
}
