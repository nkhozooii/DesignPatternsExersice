internal class Program
{
    private static void Main(string[] args)
    {
        FlyweightFactory factory = new FlyweightFactory();
        var obj1 = factory.GetFlyweight("test1");
        var obj2 = factory.GetFlyweight("test2");
        var obj3 = factory.GetFlyweight("test1");//میخواهم برای آن یک آبجکت جدید بدهد
        obj1.Operation("sample1 extrinsic state");
        obj2.Operation("sample2 extrinsic state");
        obj3.Operation("sample3 extrinsic state");

        UnsharedConcreteFlyweight flyweights = new UnsharedConcreteFlyweight(
            new Flyweight[]
            {
                factory.GetFlyweight("test1"),
                factory.GetFlyweight("test2"),
                factory.GetFlyweight("test3"),
                factory.GetFlyweight("test4"),
            });
        flyweights.Operation("extrinsic---UnsharedConcreteFlyweight");
        Console.ReadKey();
    }
}
/// <summary>
/// The 'FlyweightFactory' class
/// </summary>
public class FlyweightFactory
{
    private Dictionary<string, Flyweight> flyweights { get; set; } = new Dictionary<string, Flyweight>();
    public Flyweight GetFlyweight(string key)
    {
        Flyweight? flyweight = null;
        if (flyweights.TryGetValue(key, out flyweight)) { }
        else
        {
            flyweights.Add(key, new ConcreteFlyweight(key));
        }
        return (flyweights[key]);
    }
}
/// <summary>
/// The 'Flyweight' abstract class
/// </summary>
public abstract class Flyweight
{
    public abstract void Operation(string extrinsicstate);
}
/// <summary>
/// The 'ConcreteFlyweight' class
/// </summary>
public class ConcreteFlyweight : Flyweight
{
    private string intrinsicState;
    public ConcreteFlyweight(string intrinsicState)
    {
        this.intrinsicState = intrinsicState;

    }
    public override void Operation(string extrinsicstate)
    {
        Console.WriteLine("ConcreteFlyweight.Operation('" + intrinsicState + "'):\"" + extrinsicstate + "\"");
    }
}
/// <summary>
/// The 'UnsharedConcreteFlyweight' class
/// </summary>
public class UnsharedConcreteFlyweight : Flyweight
{
    private IEnumerable<Flyweight> flyweights;
    public UnsharedConcreteFlyweight(IEnumerable<Flyweight> flyweights)
    {
        this.flyweights = flyweights;
    }
    public override void Operation(string extrinsicstate)
    {
        Console.WriteLine("UnsharedConcreteFlyweight: " +
           extrinsicstate);
        foreach (var item in flyweights)
        {
            item.Operation(extrinsicstate);
        }

    }
}