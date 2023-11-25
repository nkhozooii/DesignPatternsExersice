internal class Program
{
    private static void Main(string[] args)
    {
        State state = new ConcreteStateA();
        Context context= new Context(state);
        context.Request();
        context.Request();
        context.Request();
        Console.ReadKey();


    }
}
public class Context
{
    private State _state;
    public State State
    {
        get { return _state; }
        set { _state = value; }
    }
    public Context(State state)
    {
        _state = state;
    }
    public void Request()
    {
        _state.Handle(this);
    }    
}
public abstract class State
{
    public abstract void Handle(Context context);

}
public class ConcreteStateA : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateA Handele Context...");
        context.State = new ConcreteStateB();
    }
}
public class ConcreteStateB : State
{
    public override void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateB Handele Context...");
        context.State = new ConcreteStateC();
    }
}
public class ConcreteStateC : State 
{
    public override void Handle(Context context)
    {
        Console.WriteLine("ConcreteStateC Handele Context...");
    }
}