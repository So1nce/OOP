public class TCircle
{
    private double radius;

    public TCircle()
    {
        radius = 0;
    }

    public TCircle(double r)
    {
        radius = r;
    }

    public TCircle(TCircle otherCircle)
    {
        radius = otherCircle.radius;
    }

    public void InputData()
    {
        Console.Write("Введіть радіус кола: ");
        radius = Convert.ToDouble(Console.ReadLine());
    }

    public String Data()
    {
        return $"Радіус кола: {radius}";
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public double CalculateSectorArea(double angle)
    {
        return (angle / 360) * CalculateArea();
    }

    public double CalculateCircumference()
    {
        return 2 * Math.PI * radius;
    }

    public bool Compare(TCircle otherCircle)
    {
        return radius == otherCircle.radius;
    }

    public static TCircle operator +(TCircle circle1, TCircle circle2)
    {
        return new TCircle(circle1.radius + circle2.radius);
    }

    public static TCircle operator -(TCircle circle1, TCircle circle2)
    {
        return new TCircle(circle1.radius - circle2.radius);
    }

    public static TCircle operator *(TCircle circle, double multiplier)
    {
        return new TCircle(circle.radius * multiplier);
    }
}