﻿internal class Program
{
    private static void Main(string[] args)
    {
        // Abstract factory #1
        AbstractFactory factory1 = new ConcreteFactory1();
        Client client1=new Client(factory1);
        client1.Run();
        // Abstract factory #2
        AbstractFactory factory2 = new ConcreteFactory2();
        Client client2 = new Client(factory2);
        client2.Run();

        Console.ReadLine();
    }
}
abstract class AbstractFactory
{
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
}
class ConcreteFactory1 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA1();
    }
    public override AbstractProductB CreateProductB()
    {
        return new ProductB1();
    }
}
class ConcreteFactory2 : AbstractFactory
{
    public override AbstractProductA CreateProductA()
    {
        return new ProductA2();
    }
    public override AbstractProductB CreateProductB()
    {
        return new ProductB2();
    }
}
abstract class AbstractProductA
{
}
class ProductA1 : AbstractProductA
{
}
class ProductA2 : AbstractProductA
{
}
abstract class AbstractProductB
{
    public abstract void Interact(AbstractProductA a);
}
class ProductB1 : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine(this.GetType().Name +
          " interacts with " + a.GetType().Name);
    }
}
class ProductB2 : AbstractProductB
{
    public override void Interact(AbstractProductA a)
    {
        Console.WriteLine(this.GetType().Name +
          " interacts with " + a.GetType().Name);
    }
}

class Client
{
    private AbstractProductA _abstractProductA;
    private AbstractProductB _abstractProductB;
    // Constructor
    public Client(AbstractFactory factory)
    {
        _abstractProductB = factory.CreateProductB();
        _abstractProductA = factory.CreateProductA();
    }
    public void Run()
    {
        _abstractProductB.Interact(_abstractProductA);
    }
}
