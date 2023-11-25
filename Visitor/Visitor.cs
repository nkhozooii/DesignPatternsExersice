using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    //می توان کلاس ویزیتور را حذف و با یکی از کانکریتها یکی کرد و نام تمام توابع آن را برای اورلودینگ ویزیت گداشت و یکی کرد
   public abstract class Visitor
    {
        public abstract void Visit(ConcreteElementA element);
        public abstract void Visit(ConcreteElementB element);
        public abstract void VisitTaxiOrder(TaxiOrder element);
        public abstract void VisitFoodOrder(FoodOrder element);
        public abstract void VisitSnappOrder(SnappOrder element);

    }
    public class ConcreteVisitor1 : Visitor
    {
        public override void Visit(ConcreteElementA element)
        {
            Console.WriteLine($"Type:{element.GetType().Name}  Name:{element.Name}  Visitor:{this.GetType().Name}");
        }

        public override void Visit(ConcreteElementB element)
        {
            Console.WriteLine($"Type:{element.GetType().Name}  Name:{element.OrderId}  Visitor:{this.GetType().Name}");
        }

        public override void VisitFoodOrder(FoodOrder element)
        {
            Console.WriteLine($"Type:{element.GetType().Name}  Visitor:{this.GetType().Name}");
        }

        public override void VisitSnappOrder(SnappOrder element)
        {
            Console.WriteLine($"Type:{element.GetType().Name}  Visitor:{this.GetType().Name}");
        }

        public override void VisitTaxiOrder(TaxiOrder element)
        {
            Console.WriteLine($"Type:{element.GetType().Name}  Visitor:{this.GetType().Name}");
        }
    }
    public class ObjectStructure
    {
        private List<Element> elements = new List<Element>();
        public void Add(Element element)
        {
            elements.Add(element);
        }
        public void Remove(Element element)
        {
            elements.Remove(element);
        }
        public void Accept(Visitor visitor)
        {
            foreach (var item in elements)
            {
                item.Accept(visitor);
            }
        }
    }
    public abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
    public class ConcreteElementA : Element
    {
        public string Name { get; private set; }
        public ConcreteElementA(string name)
        {
            this.Name = name;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class ConcreteElementB : Element
    {
        public string OrderId { get; private set; }
        public ConcreteElementB(string orderId)
        {
            this.OrderId = orderId;
        }

        public override void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
    public class TaxiOrder : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitTaxiOrder(this);
        }
    }
    public class FoodOrder : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitFoodOrder(this);
        }
    }
    public class SnappOrder : Element
    {
        public override void Accept(Visitor visitor)
        {
            visitor.VisitSnappOrder(this);
        }
    }
}
