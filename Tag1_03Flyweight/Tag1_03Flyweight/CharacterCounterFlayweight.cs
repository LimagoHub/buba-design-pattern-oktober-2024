namespace Tag1_03Flyweight;

public class CharacterCounterFlyweight
{
    private static CharacterCounterFlyweight _instance = new CharacterCounterFlyweight();
    private static Dictionary<char, int> counter = new Dictionary<char, int>();

    private CharacterCounterFlyweight()
    {
        
    }

    public static CharacterCounterFlyweight getInstance() { return _instance; }
    
    public void IncrementCounter(char character)
    {
        int anzahl = counter.GetValueOrDefault(character, 0);
        counter[character] = anzahl + 1;
    }

    public static void Print()
    {
        foreach(KeyValuePair<char, int> entry in counter)
        {
            Console.WriteLine($"Anzahl von '{entry.Key}' ist {entry.Value}");
        }
    }
}