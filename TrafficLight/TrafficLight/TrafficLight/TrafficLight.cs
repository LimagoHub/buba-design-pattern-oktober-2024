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
        public ITrafficLightState Current { get; set; }

        public TrafficLight()
        {
            RedState = new RedState(this);
            GreenState = new GreenState(this);
            Current = RedState;
        }

        public string GetColor()
        {
            return Current.GetColor();
        }
        public void NextColor()
        {
            Current.NextColor();
        }



    }
}
