internal class Program
{
    private static void Main(string[] args)
    {
        ConcreteAggregate myList= new ConcreteAggregate();
        myList[0] = "item 1";
        myList[1] = "item 2";
        myList[2] = "item 3";
        myList[3] = "item 4";

        Iterator iterator = myList.CreateIterator();
        object item = iterator.First();
        while(item!=null)
        {
            Console.WriteLine($"Find item:{item}");
            item= iterator.Next();
        }



        Console.ReadKey();
    }
}
public abstract class Aggregate
{
    public abstract Iterator CreateIterator();
}
public class ConcreteAggregate : Aggregate
{
    List<object> Items=new List<object>();
    public override Iterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }
    //get item count
    public int Count
    {
        get { return Items.Count; }
    }
    //Indexer
    public object this[int index]
    {
        get { return Items[index];}
        set { Items.Insert(index, value); }
    }
}
public abstract class Iterator
{
    public abstract object First();
    public abstract object Next();
    public abstract bool IsDone();
    public abstract object CurrentItem();
}
public class ConcreteIterator : Iterator
{
    int current=0;
    ConcreteAggregate aggregate;
    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        this.aggregate = aggregate;
    }
    public override object CurrentItem()
    {
        return aggregate[current];
    }

    public override object First()
    {
        return aggregate[0];
    }

    public override bool IsDone()
    {
        return current >= aggregate.Count;
    }

    public override object Next()
    {
        if(current<aggregate.Count-1)
        {
            return aggregate[++current];
        }
        else { return null; }
    }
}