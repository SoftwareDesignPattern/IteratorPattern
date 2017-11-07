using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class StudentIterator : IEnumerator
    {
        private List<int> number;
        private int currentPosition = -1;

        public StudentIterator(List<int> numbers)
        {
            this.number = numbers;
        }

        public object Current
        {
            get
            {
                return number[currentPosition];
            }
        }

        public bool MoveNext()
        {
            if (currentPosition < number.Count - 1)
            {
                //currentPosition = currentPosition + 2;
                currentPosition = currentPosition + 1;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            currentPosition = -1;
        }
    }
}
