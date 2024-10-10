using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_05State.Business
{
    internal class BusinessClass
    {
        public readonly State stateA;
        public readonly State stateB;
        public  State current;

        public BusinessClass()
        {
            stateA = new StateA(this);
            stateB = new StateB(this);
            current = stateA;
        }

        public void drucken()
        {
            current.drucken();
        }
        public void changeToA()
        {
            current.changeToA  ();
        }
        public void changeToB()
        {
            current.changeToB ();
        }

    }
}
