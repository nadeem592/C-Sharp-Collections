using System;

namespace GenericsExample
{
    public class TestGenerics<T>
    {
        public void add(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }
        public void sub(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }
        public void mul(T a,T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TestGenerics<int> obj = new TestGenerics<int>();
            obj.add(10, 20);
            obj.sub(10, 30);
            obj.mul(10, 20);
        }
    }
}
