using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        MyDataCollection myDatas = new MyDataCollection();
        myDatas.Add(1, "test 1");
        myDatas.Add(2, "test 2");

        var e = myDatas.GetEnumerator();

        while (e.MoveNext())
        {
            Console.WriteLine($"Id:{e.Current.Id} Text:{e.Current.Text}" );
        }

        foreach (var data in myDatas) 
        {
            Console.WriteLine($"Id:{data.Id} Text:{data.Text}");

        }
        Console.ReadKey();

    }
}
public class MyData
{
    public int Id { get; set; }
    public string Text { get; set; }
}
public class MyDataCollection:IEnumerable<MyData>
{
    private List<MyData> myDatas;
    public MyDataCollection()
    {
        myDatas = new List<MyData>();
    }
    public void Add(int id,string text)
    {
        myDatas.Add(new MyData { Id = id, Text = text });
    }

    public IEnumerator<MyData> GetEnumerator()
    {
        //استفاده از ییلد
        foreach (var item in myDatas)
        {
            yield return item;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

//می خواهیم متدهای پایین رو به جای اینکه خودمون پیاده سازی کنیم از ییلد استفاده کنیم

//public class Enumerator : IEnumerator<MyData>
//{
//    public MyData Current => throw new NotImplementedException();

//    object IEnumerator.Current => throw new NotImplementedException();

//    public void Dispose()
//    {
//        throw new NotImplementedException();
//    }

//    public bool MoveNext()
//    {
//        throw new NotImplementedException();
//    }

//    public void Reset()
//    {
//        throw new NotImplementedException();
//    }
//}