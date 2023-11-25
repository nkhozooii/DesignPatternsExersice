using System;

namespace Mediator.Structural
{
   
    public class Program
    {
        public static void Main(string[] args)
        {

            ConcreteColleague1 c1 = new ConcreteColleague1();
            ConcreteColleague2 c2 = new ConcreteColleague2();
            ConcreteMediator m = new ConcreteMediator(c1, c2);

            c1.SetMediator(m);
            c2.SetMediator(m);

            c1.Send("How are you?");
            c2.Send("Fine, thanks");

            Console.ReadKey();
        }
    }
    public abstract class Colleague
    {
        protected Mediator mediator;

        public void SetMediator(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string message)
        {
            mediator.Send(message, this);
        }
    }
    public class ConcreteColleague1 : Colleague
    {
        public override void Send(string message)
        {
            Console.WriteLine($"ConcreteColleague1 sending message----->> {message}");
            base.Send(message);
        }
        public void Receive(string message)
        {
            Console.WriteLine($"ConcreteColleague1 Received : {message}");
        }
    }
    public class ConcreteColleague2 : Colleague
    {
        public override void Send(string message)
        {
            Console.WriteLine($"ConcreteColleague2 sending message----->> {message}");
            base.Send(message);
        }
        public void Receive(string message)
        {
            Console.WriteLine($"ConcreteColleague2 Received : {message}");
        }
    }
    public abstract class Mediator
    {
        protected ConcreteColleague1 colleague1;
        protected ConcreteColleague2 colleague2;

        public Mediator(ConcreteColleague1 colleague1, ConcreteColleague2 colleague2)
        {
            this.colleague1 = colleague1;
            this.colleague2 = colleague2;
        }

        public abstract void Send(string message,
            Colleague colleague);
    } 
    public class ConcreteMediator : Mediator
    {
        public ConcreteMediator(ConcreteColleague1 colleague1, ConcreteColleague2 colleague2) : base(colleague1, colleague2)
        {
        }
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == colleague1)
                colleague2.Receive(message);
            else
                colleague1.Receive(message);
        }
    }

  
   
}
