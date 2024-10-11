using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightProject.TrafficLight
{
    internal class OffState : AbstractTrafficLightState
    {
        public OffState(TrafficLight trafficLight) : base(trafficLight)
        {
        }


        public override void SwitchOn()
        {
            TrafficLight.Current = TrafficLight.RedState;
        }
    }
}
