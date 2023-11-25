using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Proxy();
            if (1 == 1)//هنوز اینجا از کلاس واقعی نمونه سازی نشده و اگه شرط نادرست باشه منابع هدر نمی رود
            {

            }
            subject.DoAction();

            Console.ReadKey();
        }

        public interface ISubject
        {
            void DoAction();
        }

        public class RealSubject : ISubject
        {
            public void DoAction()
            {
                Console.WriteLine("RealSubject.DoAction() is Run....");
            }
        }


        public class Proxy : ISubject
        {
            private RealSubject RealSubject;

            public void DoAction()
            {
                if (RealSubject == null)
                {
                    RealSubject = new RealSubject();
                }
                RealSubject.DoAction();
            }
        }
    }


}
