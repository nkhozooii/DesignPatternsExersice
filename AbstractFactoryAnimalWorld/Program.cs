internal class Program
{
    private static void Main(string[] args)
    {
        //ContinentFactory factory1 = new AfricaFactory();
        //var Carnivore1 = factory1.CreateCarnivore();
        //Carnivore1.Eat(factory1.CreateHerbivore());
        //ContinentFactory factory2 = new AmericaFactory();
        //var Carnivore2 = factory2.CreateCarnivore();
        //Carnivore2.Eat(factory2.CreateHerbivore());
        //Console.ReadLine();

        // Create and run the African animal world
        ContinentFactory africa = new AfricaFactory();
        AnimalWorld world = new AnimalWorld(africa);
        world.RunFoodChain();
        // Create and run the American animal world
        ContinentFactory america = new AmericaFactory();
        world = new AnimalWorld(america);
        world.RunFoodChain();
        // Wait for user input
        Console.ReadKey();
    }
}
abstract class ContinentFactory //کارخانه قاره
{
    public abstract Herbivore CreateHerbivore();//گیاهخوارA
    public abstract Carnivore CreateCarnivore();//گوشتخوارB
}
class AfricaFactory : ContinentFactory //کارخانه آفریقا
{
    public override Herbivore CreateHerbivore()
    {
        return new Wildebeest();
    }
    public override Carnivore CreateCarnivore()
    {
        return new Lion();
    }
}
class AmericaFactory : ContinentFactory //کارخانه آمریکا
{
    public override Herbivore CreateHerbivore()
    {
        return new Bison();
    }
    public override Carnivore CreateCarnivore()
    {
        return new Wolf();
    }
}
abstract class Herbivore //A
{
}
class Wildebeest : Herbivore //A1 کل یالدار
{
}
class Bison : Herbivore //A2 گاومیش 
{
}
abstract class Carnivore //B
{
    public abstract void Eat(Herbivore h);
}
class Lion : Carnivore //B1 شیر
{
    public override void Eat(Herbivore h)
    {
        // Eat Wildebeest
        Console.WriteLine(this.GetType().Name +
          " eats " + h.GetType().Name);
    }
}
class Wolf : Carnivore //B2 گرگ
{
    public override void Eat(Herbivore h)
    {
        // Eat Bison
        Console.WriteLine(this.GetType().Name +
          " eats " + h.GetType().Name);
    }
}

//Client
class AnimalWorld
{
    private Herbivore _herbivore;
    private Carnivore _carnivore;
    // Constructor
    public AnimalWorld(ContinentFactory factory)
    {
        _carnivore = factory.CreateCarnivore();
        _herbivore = factory.CreateHerbivore();
    }
    public void RunFoodChain()
    {
        _carnivore.Eat(_herbivore);
    }
}