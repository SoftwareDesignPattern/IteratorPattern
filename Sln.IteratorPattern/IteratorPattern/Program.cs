using System;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentCollection _StudentCollection = new StudentCollection();

            _StudentCollection.Add(1);
            _StudentCollection.Add(2);
            _StudentCollection.Add(3);
            _StudentCollection.Add(4);
            _StudentCollection.Add(5);


            _StudentCollection.Add(6);
            _StudentCollection.Add(7);
            _StudentCollection.Add(8);
            _StudentCollection.Add(9);
            _StudentCollection.Add(10);



            foreach (var item in _StudentCollection)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();

        }
    }
}
