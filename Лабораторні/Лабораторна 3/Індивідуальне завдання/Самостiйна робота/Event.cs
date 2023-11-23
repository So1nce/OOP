public class Event
{
    public string Date { get; set; }
    public string Result { get; set; }
    public string IpFrom { get; set; }
    public string Method { get; set; }
    public string UrlTo { get; set; }
    public int Response { get; set; }

    public override string ToString()
    {
        return $"Дата: {Date}\nРезультат: {Result}\nIP-адреса: {IpFrom}\nМетод: {Method}\nURL: {UrlTo}\nВідповідь: {Response}\n";
    }
}