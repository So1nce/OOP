public class Boy
{
    public Boy()
    {
        Flower.Event1 += Event1Handler;
        Flower.Event2 += Event2Handler;
    }

    private void Event1Handler()
    {
        Console.WriteLine("Я не могу, я болен");
    }

    private void Event2Handler()
    {
        Console.WriteLine("Ура!!! Я здоров");
    }
}