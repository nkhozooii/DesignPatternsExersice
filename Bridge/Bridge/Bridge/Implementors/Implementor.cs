using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Bridge.Implementors
{
    public abstract class Implementor
    {
        public abstract void Implementaion();
    }

    public class ConcreateImplementorA: Implementor
    {
        public override void Implementaion()
        {
            Console.WriteLine("Run   ConcreateImplementorA.Implementaion()....");
        }
    }
    public class ConcreateImplementorB : Implementor
    {
        public override void Implementaion()
        {
            Console.WriteLine("Run   ConcreateImplementorB.Implementaion()....");
        }
    }
}
