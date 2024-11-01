namespace Tag3_03Template.processor;

public class CharacterSumGroup: FileHandler
{
    
    private Dictionary<char, int> characterSums = new Dictionary<char, int>();
    public void Init()
    {
        characterSums.Clear();
    }

    public void Dispose()
    {
        foreach(KeyValuePair<char, int> entry in characterSums)
        {
            Console.WriteLine($"Anzahl von '{entry.Key}' ist {entry.Value}");
        }
    }

    public void Process(char c)
    {
        characterSums[c] = characterSums.GetValueOrDefault(c,0) + 1;
    }
}