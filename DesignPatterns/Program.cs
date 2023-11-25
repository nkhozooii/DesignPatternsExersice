using Decorator;
///Decorator:

//Without Decorator:
ConcreteComponent concreteComponent = new ConcreteComponent();
//concreteComponent.Operation();

//using Decorator:
ConcreteDecoratorA concreteDecoratorA = new ConcreteDecoratorA(concreteComponent);
concreteDecoratorA.Operation();

ConcreteDecoratorB concreteDecoratorB = new ConcreteDecoratorB(concreteDecoratorA);
concreteDecoratorB.Operation();

Console.ReadLine();

