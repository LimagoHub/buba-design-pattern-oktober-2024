namespace Tag1_03Flyweight;

public class AttributedCharacter
{
    
    private static IList<AttributedCharacter> _characters = new List<AttributedCharacter>();
    public char c { get;  }
    public bool bold { get;  }

    private AttributedCharacter(char c, bool bold)
    {
        this.c = c;
        this.bold = bold;
        _characters.Add(this);
    }

    public static AttributedCharacter GetInstance(char c, bool bold)
    {
        foreach (var character in _characters)
        {
            if(character.c == c && character.bold == bold) return character;
        }
        return new AttributedCharacter(c, bold);
    } 
}