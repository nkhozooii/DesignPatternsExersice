using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Component
    {
        public abstract void Operation();
        
    }
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation is running");
        }
    }
    public abstract class Decorator:Component
    {
        private readonly Component _component;
        public Decorator(Component component)
        {
            _component = component;
        }
        public override void Operation()
        {
            if (_component != null)
            {
                _component.Operation();
            }
        }
    }
    public class ConcreteDecoratorA : Decorator
    {
      
        public ConcreteDecoratorA(Component component) : base(component)
        {
           
        }
        public override void Operation()
        {
            base.Operation();
            NewFeature();
        }
        public void NewFeature()
        {
            Console.WriteLine("ConcreteDecoratorA.NewFeature1 running...");
        }
    }
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {
        }
        public override void Operation()
        {
            base.Operation();
            NewFeature();
        }
        public void NewFeature()
        {
            Console.WriteLine("ConcreteDecoratorB.NewFeature2 running...");
        }
    }
}
