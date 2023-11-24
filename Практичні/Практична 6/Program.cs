public class Program
{
    static void Main()
    {
        Flower flower = new Flower();
        Girl<string> girl = new Girl<string>(new string[] {
            "Хочу с тобой гулять",
            "Хочу с тобой играть",
            "Хочу с тобой плавать",
            "Хочу с тобой кататься",
            "Хочу с тобой бегать",
            "Хочу с тобой прыгать"
        });
        Boy boy = new Boy();

        while (Flower.PetalsCount > 0)
        {
            flower.GenerateEvent();
        }
    }
}