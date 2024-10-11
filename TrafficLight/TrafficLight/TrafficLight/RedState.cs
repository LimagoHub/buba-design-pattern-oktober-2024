using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightProject.TrafficLight
{
    internal class RedState : AbstractTrafficLightColorState
    {
        public RedState(TrafficLight trafficLight) : base(trafficLight)
        {
        }

        public override string GetColor()
        {
            return "RED";
        }

        public override void NextColor()
        {
            TrafficLight.Current = TrafficLight.GreenState;
        }
    }
}
