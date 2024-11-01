namespace Tag1_03Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader("c:\\tmp\\baerchen.txt"))
            {
                int zeichen;
                
                while ((zeichen = reader.Read()) != -1)
                {
                    CharacterCounterFlyweight.getInstance().IncrementCounter((char)zeichen);
                }

                CharacterCounterFlyweight.Print();


            }
        }
    }

}

