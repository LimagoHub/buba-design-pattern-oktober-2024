using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_05State.Business
{
    internal class StateB : AbstractState
    {
        public StateB(BusinessClass businessClass) : base(businessClass)
        {
        }

        public override void drucken()
        {
            Console.WriteLine("Hier druckt B");
        }

        public override void changeToA()
        {
            BusinessClass.current = BusinessClass.stateA;
        }
    }
}
