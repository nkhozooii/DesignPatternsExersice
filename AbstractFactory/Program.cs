AbstractFactory factory = new ConcreteFactory2();
var productA=factory.CreateProductA();
productA.Execute();
var productB=factory.CreateProductB();
productB.Execute();
Console.ReadLine();

//
public interface AbstractFactory
{
    ProductA CreateProductA();
    ProductB CreateProductB();
}
public class ConcreteFactory1 : AbstractFactory
{
    public ProductA CreateProductA()
    {
        return new ProductA1();
    }

    public ProductB CreateProductB()
    {
        return new ProductB1();
    }
}
public class ConcreteFactory2 : AbstractFactory
{
    public ProductA CreateProductA()
    {
        return new ProductA2();
    }

    public ProductB CreateProductB()
    {
        return new ProductB2();
    }
}
/////////////////ProductA:
public interface ProductA
{
    void Execute();
}
public class ProductA1 : ProductA
{
    public void Execute()
    {
        Console.WriteLine("ProductA1");
    }
}
public class ProductA2 : ProductA
{
    public void Execute()
    {
        Console.WriteLine("ProductA2");
    }
}

/////////////////ProductB:

public interface ProductB
{
    void Execute();
}
public class ProductB1 : ProductB
{
    public void Execute()
    {
        Console.WriteLine("ProductB1");
    }
}
public class ProductB2 : ProductB
{
    public void Execute()
    {
        Console.WriteLine("ProductB2");
    }
}
