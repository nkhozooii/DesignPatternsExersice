using Bridge.Bridge.Abstractions;
using Bridge.Bridge.Implementors;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreateImplementorA();          
            ab.Function();

            Console.ReadKey();
        }
    }
}
