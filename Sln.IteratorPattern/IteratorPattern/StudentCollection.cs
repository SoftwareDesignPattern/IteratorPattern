using System.Collections;
using System.Collections.Generic;

namespace IteratorPattern
{
    class StudentCollection : IEnumerable
    {
        List<int> studentList = new List<int>();

        public void Add(int number)
        {
            studentList.Add(number);
        }

        public IEnumerator GetEnumerator()
        {
            return new StudentIterator(studentList);
        }
    }
}
