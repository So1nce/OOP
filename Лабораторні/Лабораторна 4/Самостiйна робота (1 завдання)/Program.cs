using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        TCircle circle1 = new TCircle();
        TCircle circle2 = new TCircle(5);
        TCircle circle3 = new TCircle(circle2);

        circle1.InputData();

        Console.WriteLine("Дані першого кола:");
        Console.WriteLine(circle1.Data());
        Console.WriteLine($"Площа кола: {circle1.CalculateArea()}");
        Console.WriteLine($"Довжина кола: {circle1.CalculateCircumference()}");

        Console.WriteLine("Дані другого кола:");
        Console.WriteLine(circle2.Data());

        Console.WriteLine("Дані третього кола (копії другого кола):");
        Console.WriteLine(circle3.Data());

        if (circle1.Compare(circle2))
            Console.WriteLine("Перше коло рівне другому колу.");
        else
            Console.WriteLine("Перше коло не рівне другому колу.");

        TCircle circleSum = circle1 + circle2;
        Console.WriteLine($"Сума радіусів першого і другого кола: {circleSum.Data()}");

        TCircle circleDiff = circle1 - circle2;
        Console.WriteLine($"Різниця радіусів першого і другого кола: {circleDiff.Data()}");

        double multiplier = 2.5;
        TCircle circleProduct = circle1 * multiplier;
        Console.WriteLine($"Радіус першого кола, помножений на {multiplier}: {circleProduct.Data()}");

        TCone cone = new TCone(3, 4);
        Console.WriteLine(cone.Data());
        Console.WriteLine($"Об'єм конуса: {cone.CalculateVolume()}");

        Console.ReadLine();
    }
}