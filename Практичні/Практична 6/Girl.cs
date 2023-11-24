public class Girl<T>
{
    private List<T> wishes;

    public Girl(T[] initialWishes)
    {
        wishes = new List<T>(initialWishes);
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