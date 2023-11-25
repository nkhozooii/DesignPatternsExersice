using Composite;
namespace Composite
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Composite composite = new Composite
                   ("Root Item", new Composite[]
                   {
                    new Leaf("Leaf 1"),
                    new Composite ("Composite 1",new Composite[]
                    {
                        new Leaf("Leaf 1-1"),
                        new Leaf("Leaf 1-2"),
                        new Composite("Composite 1-1",new Composite[]
                        {
                            new Leaf("Laef 1-1-1-"),
                            new Composite("empty Composite",new Composite[]{ }),
                        })
                    }),
                    new Leaf("Leaf 2"),
                    new Leaf("Leaf 3"),
                    new Leaf("Leaf 4"),
                   });
            composite.Display(1);
            Console.ReadLine();
        }
    }
}