using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightProject.TrafficLight
{
    internal interface ITrafficLightState
    {
        string GetColor();
        void NextColor();
    }
}
