using State.Orders;
using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order(new Waiting_to_SendState());

           // order.Cancel();

            order.Send();
            order.Delivered();

            Console.Read();
        }
    }
}
