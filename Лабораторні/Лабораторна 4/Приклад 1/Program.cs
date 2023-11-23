namespace Sample01
{
    class Point
    {
        int x, y;

        Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Point operator ++(Point par) 
        {
            par.x++;
            par.y++;
            return par;
        }

        public static Point operator --(Point par)
        {
            par.x--;
            par.y--;
            return par;
        }

        public static Point operator +(Point par1, Point par2)
        {
            return new Point(par1.x + par2.x, par1.y + par2.y);
        }

        class Program
        {
            static void Main(string[] args)
            {
                Point p = new Point();
                p++;
                Console.WriteLine("x={0} y={1}", p.x, p.y);
                ++p;
                Console.WriteLine("x={0} y={1}", p.x, p.y);
                p--;
                Console.WriteLine("x={0} y={1}", p.x, p.y);
                --p;
                Console.WriteLine("x={0} y={1}", p.x, p.y);

                Point point1 = new Point(1, 2);
                Point point2 = new Point(3, 4);

                Point result = point1 + point2;

                Console.WriteLine($"Результат додавання: x = {result.x}, y = {result.y}");
            }
        }
    }
}