using FactoryMethod.Sms;
using FactoryMethod.Sms.FactoryMethod;
using FactoryMethod.Sms.Kavenegar;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ISmsManager sms;
            ICreator creator = new Creator();
            sms = creator.FacatoryMethod();
            sms.Send(new SmsDto
            {
                Message = "test",
                Reciver = "0912000000",
            });
            Console.ReadLine();
        }
    }
}
