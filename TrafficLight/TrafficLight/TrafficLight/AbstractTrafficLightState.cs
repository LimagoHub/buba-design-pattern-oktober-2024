using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightProject.TrafficLight
{
    internal class AbstractTrafficLightState : ITrafficLightState
    {
        public TrafficLight TrafficLight { get;  }

        public AbstractTrafficLightState(TrafficLight trafficLight)
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
    }
}
