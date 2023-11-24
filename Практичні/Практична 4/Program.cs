public class Program
{
    static void Main()
    {
        Flower flower = new Flower();
        Girl girl = new Girl();
        Boy boy = new Boy();

        while (Flower.PetalsCount > 0)
        {
            flower.GenerateEvent();
        }
    }
}