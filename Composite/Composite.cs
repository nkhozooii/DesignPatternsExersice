using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    //public abstract class Component
    //{
    //    protected string name;
    //    public Component(string name)
    //    {
    //        this.name = name;
    //    }
    //    public abstract void Display(int Depth);
    //    public abstract void Add(Component component);
    //    public abstract void Remove(Component component);
    //}
    public class Composite 
    {
        private List<Composite> _components = new List<Composite>();

        protected string name;
        public Composite(string name) 
        {
            this.name = name;
        }
        public Composite(string name, Composite[] components) 
        {
            this.name = name;
            foreach (var item in components)
            {
               Add(item);
            }
        }
        public virtual void Add(Composite component)
        {
            _components.Add(component);
        }

        public virtual void Display(int Depth)
        {
            Console.WriteLine(new string('-', Depth) + name);
            foreach (var item in _components)
            {
                item.Display(Depth + 2);
            }
        }

        public virtual void Remove(Composite component)
        {
            _components.Remove(component);
        }
    }
    public class Leaf :Composite
    {
        public Leaf(string name) : base(name)
        {
        }
      
        public override void Display(int Depth)
        {
            Console.WriteLine(new string('-', Depth) + name);

        }


    }
}
