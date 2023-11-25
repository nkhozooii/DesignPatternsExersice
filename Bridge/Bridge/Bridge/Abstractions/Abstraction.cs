using Bridge.Bridge.Implementors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Bridge.Abstractions
{
    public abstract  class Abstraction
    {
        private Implementor implementor;
        //public Abstraction()
        //{
        //    implementor =new  ConcreateImplementor();
        //}
        public Implementor Implementor
        {
            set { implementor = value; }
        }
        public virtual void Function()
        {
            implementor.Implementaion();
        }
    }


    public class RefinedAbstraction:Abstraction
    {

    }
}
