using System.Xml.Serialization;

public class Note
{
    public int Id { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }
    public string Subject { get; set; }
    public string Text { get; set; }
    public string Tel { get; set; }

    public override string ToString()
    {
        return $"Note ID: {Id}\nDate: {Date}\nTime: {Time}\nSubject: {Subject}\nText: {Text}\nTel: {Tel}\n";
    }
}