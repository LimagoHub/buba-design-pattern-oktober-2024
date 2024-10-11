using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightProject.TrafficLight
{
    internal class GreenState : AbstractTrafficLightState
    {
        public GreenState(TrafficLight trafficLight) : base(trafficLight)
        {
        }

        public override string GetColor()
        {
            return "Green";
        }

        public override void NextColor()
        {
            TrafficLight.Current = TrafficLight.RedState;
        }
    }
}
