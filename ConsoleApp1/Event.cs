namespace ConsoleApp1;

public class Event
{
    public int NumberMove { get; private set; }
    public string Description { get; private set; }
    public string Type { get; private set; }
    public string Change { get; private set; }

    public Event(int numberMove, string description, string type, string change)
    {
        NumberMove = numberMove;
        Description = description;
        Type = type;
        Change = change;
    }
    
}