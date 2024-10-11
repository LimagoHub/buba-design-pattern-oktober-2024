using TrafficLightProject.TrafficLight;

namespace Programm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLight trafficLight = new TrafficLight();
            trafficLight.SwitchOn();
            for (int i = 0; i < 10; i++) {
                Console.WriteLine(trafficLight.GetColor());
                trafficLight.NextColor();
            }
        }
    }
}
