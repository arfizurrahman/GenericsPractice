using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T input)
        {
        }
    }

    class Program
    {
        private class MyClass1
        {
            
        }
        static void Main(string[] args)
        {
            //Declare a list of type int.
            GenericList<int> intList = new GenericList<int>();
            intList.Add(1);

            //Declare list of type string 
            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("item1");

            //Declare list of type MyClass1
            GenericList<MyClass1> myClassList = new GenericList<MyClass1>();
            myClassList.Add(new MyClass1());
            Console.ReadKey();
        }
    }
}
