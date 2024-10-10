namespace Tag1_02Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mysingleton = MySingleton.GetInstance();
            var myOthersingleton = MySingleton.GetInstance();

            Console.WriteLine(mysingleton == myOthersingleton);
        }
    }
}
