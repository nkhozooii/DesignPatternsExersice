Context context;
context = new(new ConcreteStategyA());
context.ContextInterface();
///
context = new(new ConcreteStategyC());
context.ContextInterface();
//
context = new(new ConcreteStategyB());
context.ContextInterface();
//
Console.ReadLine();