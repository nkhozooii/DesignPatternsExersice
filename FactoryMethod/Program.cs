Creator creator = new ConcreteCreator();
Product p;
p=creator.FactoryMethod(0);
p.Execute();
p = creator.FactoryMethod(1);
p.Execute();
p = creator.FactoryMethod(2);
p.Execute();
Console.ReadLine();
/// //////////////////////////////
public abstract class Product
{
    public abstract void Execute();
}
public class ConcreteProduct1 : Product
{
    public override void Execute()
    {
        Console.WriteLine("ConcreteProduct1.Execute is running...");
    }
}
public class ConcreteProduct2 : Product
{
    public override void Execute()
    {
        Console.WriteLine("ConcreteProduct2.Execute is running...");
    }
}
public abstract class Creator
{
    public abstract Product FactoryMethod(int i);
}
public class ConcreteCreator : Creator
{
    public override Product FactoryMethod(int i)
    {
        if(i<=0)
        {
           return new ConcreteProduct1();
        }
        else 
        {
            return new ConcreteProduct2();
        }
        
    }
}