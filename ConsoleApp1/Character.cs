namespace ConsoleApp1;

public class Character
{
    public string Name { get; private set; }
    public string Class { get; private set; }
    public uint Rank { get; private set; }
    public uint Health { get; private set; }
    public uint Gold { get; private set; }
    public string State { get; private set; }

    public Character(string name, string aclass, uint rank, uint health, uint gold, string state)
    {
        Name = name;
        Class = aclass;
        Rank = rank;
        Health = health;
        Gold = gold;
        State = state;
    }

    public override string ToString()
    {
        return $"{Name}, {Class}";
    }
}