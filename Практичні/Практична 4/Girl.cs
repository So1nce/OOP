public class Girl
{
    private List<string> wishes = new List<string> { 
        "Хочу с тобой гулять",
        "Хочу с тобой играть", 
        "Хочу с тобой плавать", 
        "Хочу с тобой кататься",
        "Хочу с тобой бегать",
        "Хочу с тобой прыгать"
    };

    public Girl()
    {
        Flower.Event1 += Event1Handler;
        Flower.Event2 += Event2Handler;
    }

    private void Event1Handler()
    {
        if (wishes.Count > 0)
        {
            int index = new Random().Next(wishes.Count);
            Console.WriteLine(wishes[index]);
            wishes.RemoveAt(index);
        }
    }

    private void Event2Handler()
    {
        Console.WriteLine("Хочу, чтобы ты выздоровел");
    }
}