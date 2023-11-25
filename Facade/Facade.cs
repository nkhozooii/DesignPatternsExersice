using Facade.SubSystem1;
using Facade.SubSystem2;
using Facade.SubSystem3;

namespace FacadePattern
{
    public static class Facade
    {
        public static void DoSomething()
        {
            Class1 c1=new();
            Class2 c2 = new();
            Class3 c3 = new();
            c1.Action1();
            c2.Action2();
            c3.Action3();

        }

    }
}
