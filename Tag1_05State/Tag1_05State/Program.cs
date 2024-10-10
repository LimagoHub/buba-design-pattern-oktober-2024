using Tag1_05State.Business;

namespace Tag1_05State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessClass businessClass = new BusinessClass();
            businessClass.drucken();
            businessClass.changeToB();
            businessClass.drucken();
            businessClass.changeToB();
        }
    }
}
