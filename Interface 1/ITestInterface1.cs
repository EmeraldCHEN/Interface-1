using System;

namespace Interface_1
{
    // The default scope of the members of an interface is public
    // whereas it's private in case of a class

    // By default every member of an interface is abstract so we don't require to use abstract modifier
    interface ITestInterface1
    {
        // int x; -> Interfaces cannot contain fields
        void Add(int a, int b);
    }
    interface ITestInterface2: ITestInterface1
    {
        void Sub(int a, int b);
    }
    // If required an interface can inherit from aother interface
    class ImplementationClass : ITestInterface2
    {
        public void Add(int x, int y)
        {
            Console.WriteLine("x + y = " + (x + y));
        }
        // Every member of an interface should be implemented under the child class
        public void Sub(int x, int y)
        {
            Console.WriteLine("x - y = " + (x - y));
        } 
    }
}
