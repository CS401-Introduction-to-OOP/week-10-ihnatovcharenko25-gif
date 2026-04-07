using System.Collections;

namespace ConsoleApp1;

public class Party : IEnumerable<Character>
{
    private List<Character> _characters;
    private int _iterator = 0;

    public Party()
    {
        _characters = new List<Character>();
    }

    public void Add(Character character)
    {
        _characters.Add(character);
    }
    
    public IEnumerator<Character> GetEnumerator()
    {
        foreach (Character character in _characters)
            yield return character;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    
    public IEnumerable<Character> GetIAliveEnumerator()
    {
        foreach (Character c in _characters)
            if (c.State == "Alive")
                yield return c;
    }
    
    public IEnumerable<Character> GetLowHpEnumerator(int hp)
    {
        foreach (Character c in _characters)
            if (c.Health < hp)
                yield return c;
    }

    
     public IEnumerator<Character> WhereLevelHigher(int level)
     
        => _characters.Where<Character>(c => c.Rank > level).GetEnumerator();
    
    public IEnumerator<Character> OrderByLevel()
        => _characters.OrderBy(c => c.Rank).GetEnumerator();

    public Character MaxLevel()
        => _characters.MaxBy(c => c.Rank);

}