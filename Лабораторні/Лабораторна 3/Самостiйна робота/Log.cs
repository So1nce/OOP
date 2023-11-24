public class Log
{
    public List<Event> Events { get; set; } = new List<Event>();

    public void AddEvent(Event logEvent)
    {
        Events.Add(logEvent);
    }

    public override string ToString()
    {
        return string.Join("\n", Events);
    }
}