using System.Xml.Serialization;

public class Notepad
{
    public List<Note> Notes { get; set; } = new List<Note>();

    public void AddNote(Note note)
    {
        Notes.Add(note);
    }

    public override string ToString()
    {
        return string.Join("\n", Notes);
    }
}