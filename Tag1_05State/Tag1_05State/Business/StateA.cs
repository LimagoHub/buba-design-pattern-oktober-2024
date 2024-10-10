using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_05State.Business
{
    internal class StateA : AbstractState
    {
        public StateA(BusinessClass businessClass) : base(businessClass)
        {
        }

        public override void changeToB()
        {
            BusinessClass.current = BusinessClass.stateB;
        }

        public override void drucken()
        {
            Console.WriteLine("Hier druckt A");
        }
    }
}
