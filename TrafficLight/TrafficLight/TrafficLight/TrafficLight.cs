using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightProject.TrafficLight
{
    internal class TrafficLight
    {
        public ITrafficLightState RedState { get;}
        public ITrafficLightState GreenState { get; }
        public ITrafficLightState OffState { get; }
        public ITrafficLightState Current { get; set; }

        public TrafficLight()
        {
            RedState = new RedState(this);
            GreenState = new GreenState(this);
            OffState = new OffState(this);
            Current = OffState;
        }

        public string GetColor()
        {
            return Current.GetColor();
        }
        public void NextColor()
        {
            Current.NextColor();
        }

        public void SwitchOn()
        {
            Current.SwitchOn();
        }

        public void SwitchOff()
        {
            Current.SwitchOff();
        }

    }
}
