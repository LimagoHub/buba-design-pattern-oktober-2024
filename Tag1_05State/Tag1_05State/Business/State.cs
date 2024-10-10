using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_05State.Business
{
    internal interface State
    {
        void drucken();
        void changeToA();
        void changeToB();
    }
}
