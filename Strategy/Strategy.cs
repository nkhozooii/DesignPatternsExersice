using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Context
{
    private Strategy strategy;
    public Context(Strategy strategy)
    {
        this.strategy = strategy;
    }
    public void ContextInterface()
    {
        strategy.AlgorithmInterface();
    }
}
public abstract class Strategy
{
    public abstract void AlgorithmInterface();
}
public class ConcreteStategyA : Strategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine("ConcreteStategyA.AlgorithmInterface is running...");
    }
}
public class ConcreteStategyB : Strategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine("ConcreteStategyB.AlgorithmInterface is running...");
    }
}
public class ConcreteStategyC : Strategy
{
    public override void AlgorithmInterface()
    {
        Console.WriteLine("ConcreteStategyC.AlgorithmInterface is running...");
    }
}

