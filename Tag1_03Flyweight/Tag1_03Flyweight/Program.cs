namespace Tag1_03Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
           AttributedCharacter a1 = AttributedCharacter.GetInstance('A', false);
           AttributedCharacter a2 = AttributedCharacter.GetInstance('A', false);
           AttributedCharacter a3 = AttributedCharacter.GetInstance('A', true);
           
           Console.WriteLine(a1 == a2);
           Console.WriteLine(a1 == a3);
        }
    }

}

