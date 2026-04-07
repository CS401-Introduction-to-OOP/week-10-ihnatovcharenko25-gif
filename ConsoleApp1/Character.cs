namespace ConsoleApp1;

public class Character
{
    public string Name { get; private set; }
    public string Class { get; private set; }
    public int Rank { get; private set; }
    public int Health { get; private set; }
    public int Gold { get; private set; }
    public string State { get; private set; }

    public Character(string name, string aclass, int rank, int health, int gold, string state)
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
        return $"{Name}, {Class} - {Health} hp, {Gold} gold";
    }
}