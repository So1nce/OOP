using System.Xml;

public class XmlParse
{
    public static Notepad ParseNotepad(string xmlString)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(xmlString);

        Notepad notepad = new Notepad();

        foreach (XmlNode noteNode in xmlDoc.SelectNodes("/notepad/note"))
        {
            int id = int.Parse(noteNode.Attributes["id"].Value);
            string date = noteNode.Attributes["date"].Value;
            string time = noteNode.Attributes["time"].Value;
            string subject = noteNode.SelectSingleNode("subject").InnerText;
            string text = noteNode.SelectSingleNode("text").InnerText.Trim();
            string tel = noteNode.SelectSingleNode("text/tel")?.InnerText;

            Note note = new Note
            {
                Id = id,
                Date = date,
                Time = time,
                Subject = subject,
                Text = text,
                Tel = tel
            };

            notepad.AddNote(note);
        }

        return notepad;
    }

    public static Log ParseLog(string xmlString)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(xmlString);

        Log log = new Log();

        foreach (XmlNode eventNode in xmlDoc.SelectNodes("/log/event"))
        {
            string date = eventNode.Attributes["date"].Value;
            string result = eventNode.Attributes["result"].Value;
            string ipFrom = eventNode.SelectSingleNode("ip-from").InnerText.Trim();
            string method = eventNode.SelectSingleNode("method").InnerText.Trim();
            string urlTo = eventNode.SelectSingleNode("url-to").InnerText.Trim();
            int response = int.Parse(eventNode.SelectSingleNode("response").InnerText);

            Event logEvent = new Event
            {
                Date = date,
                Result = result,
                IpFrom = ipFrom,
                Method = method,
                UrlTo = urlTo,
                Response = response
            };

            log.AddEvent(logEvent);
        }

        return log;
    }
}