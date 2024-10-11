using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightProject.TrafficLight
{
    internal abstract class AbstractTrafficLightColorState : AbstractTrafficLightState
    {


        public AbstractTrafficLightColorState(TrafficLight trafficLight) : base(trafficLight)
        {
        }

     

        public override void SwitchOff()
        {
            TrafficLight.Current = TrafficLight.OffState;
        }
    }
}
