using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tag1_05State.Business
{
    internal abstract class AbstractState: State
    {
        private readonly BusinessClass businessClass;

        protected AbstractState(BusinessClass businessClass)
        {
            this.businessClass = businessClass;
        }

        internal BusinessClass BusinessClass => businessClass;

        public virtual void changeToA()
        {
            throw new InvalidOperationException("Diese Methode macht in diesem Zustand keinen Sinn");
        }

        public virtual void changeToB()
        {
            throw new InvalidOperationException("Diese Methode macht in diesem Zustand keinen Sinn");
        }

        public virtual void drucken()
        {
            throw new InvalidOperationException("Diese Methode macht in diesem Zustand keinen Sinn");
        }
    }
}
