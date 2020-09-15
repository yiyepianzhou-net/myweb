using System;
using System.Collections;

namespace AsyncTaskAndForEarch
{
    class Program
    {
        static void Main(string[] args)
        {

           
    
        }

        public void synchronization()
        {
            Console.WriteLine("Hello World!");
            new asyncTest().Print();
        }
    }

    public class asyncTest : IEnumerable, IEnumerator
    {
        private  readonly int[] a = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        private int top = -1;
        object IEnumerator.Current => a[top];

        public IEnumerator GetEnumerator()
        {
            return new asyncTest();
        }

        public bool MoveNext()
        {
            top++;
            return top < a.Length;
        }

        public void Reset()
        {
            top = -1;
        }

        public  void Print()
        {
            foreach (var item in this)
                System.Console.WriteLine(item);
        }



    }
}
