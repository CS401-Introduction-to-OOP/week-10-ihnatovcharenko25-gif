using System.Collections;

namespace ConsoleApp1;

public class EventLog : IEnumerable<Event>
{
    private List<Event> _events;

    public EventLog()
    {
        _events = new List<Event>();
    }

    public void Add(Event e)
    {
        _events.Add(e);
    }
    public IEnumerator<Event> GetEnumerator()
    {
        foreach (Event e in _events)
            yield return e;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    
}