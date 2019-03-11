using System;

namespace Interface_1
{
    // Class: user-defined data type, non-abstract methods(methods with method body)
    class Program
    {
        static void Main()
        {
            ImplementationClass obj = new ImplementationClass();
            obj.Add(100, 11);
            obj.Sub(100, 11);

            ITestInterface2 i = obj;
            i.Add(100, 11);
            i.Sub(100, 11);
            
            Console.ReadKey();
        }
    }
}

/* Interface: user-defined data type only, contains only abstract method(methods without method body)
              Every abstract method of an interface shoud be implemented by the child class of the interface

   Abstract class: Non-abstract methods and also abstract methods

    
Note:
    Generally a class inherits from another class to consume the members of its parent,

    whereas if a class is inheriting from an interface it's to implement the the members of its parent
                                                              
    A class can inherit from a class and interface at a time
    
 */
