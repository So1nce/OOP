public class TCone : TCircle
{
    private double height;

    public TCone(double r, double h) : base(r)
    {
        height = h;
    }

    public new String Data()
    {
        base.Data();
        return $"Висота конуса: {height}";
    }

    public double CalculateVolume()
    {
        return (1.0 / 3) * base.CalculateArea() * height;
    }
}