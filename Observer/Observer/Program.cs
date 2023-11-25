using System;
using System.Collections.Generic;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();
            var observer1 = new ConcreteObserver("observer 1", concreteSubject);
            var observer2 = new ConcreteObserver("observer 2", concreteSubject);
            var observer3 = new ConcreteObserver("observer 3", concreteSubject);

            concreteSubject.Attach(observer1);
            concreteSubject.Attach(observer2);
            concreteSubject.Attach(observer3);

            var observer4 =  new ConcreteObserver("observer 4", concreteSubject);
            concreteSubject.Attach(observer4);


            //اعمال تغییرات
            concreteSubject.SubjectState = "test patterns";
            concreteSubject.Notify();

            Console.WriteLine("---------------------------------------");
            concreteSubject.Detach(observer4);
            concreteSubject.SubjectState = "Test";
            concreteSubject.Notify();
            Console.Read();
        }
    }

    public abstract class Observer
    {
        public abstract void Update();
    }

    public abstract class Subject
    {
        private List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }

    }

    public class ConcreteSubject : Subject
    {
        public string SubjectState { get; set; }
    }

    public class ConcreteObserver : Observer
    {

        public string Name { get; set; }
        public ConcreteSubject concreteSubject { get; set; }
        public ConcreteObserver(string Name, ConcreteSubject concreteSubject)
        {
            this.Name = Name;
            this.concreteSubject = concreteSubject;
        }

        public override void Update()
        {
            Console.WriteLine($"{Name } : observerState update = {concreteSubject.SubjectState} ");
        }
    }
}
