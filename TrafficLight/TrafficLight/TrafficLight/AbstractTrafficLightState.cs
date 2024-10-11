using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightProject.TrafficLight
{
    internal abstract class AbstractTrafficLightState : ITrafficLightState
    {
        public TrafficLight TrafficLight { get;  }

        protected AbstractTrafficLightState(TrafficLight trafficLight)
        {
            TrafficLight = trafficLight;
        }

     

        public virtual string GetColor()
        {
            throw new InvalidOperationException("Upps");
        }

        public virtual void NextColor()
        {
            throw new InvalidOperationException("Upps");
        }

        public virtual void SwitchOn()
        {
            throw new InvalidOperationException("Upps");
        }

        public virtual void SwitchOff()
        {
            throw new InvalidOperationException("Upps");
        }
    }
}
