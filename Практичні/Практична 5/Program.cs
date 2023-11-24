public class Program
{
    static int[] numbers = new int[10];
    static object lockObject = new object();

    static void Main()
    {
        // Ініціалізація та виведення масиву
        InitArray();
        PrintArray();

        // Створення та запуск потоків
        Thread t0 = new Thread(PrintNumbersLessThan15);
        Thread t1 = new Thread(CalculateGeometricMean);

        t0.Start();
        t1.Start();

        t0.Join();
        t1.Join();
    }

    static void InitArray()
    {
        Random random = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(0, 26);
        }
    }

    static void PrintArray()
    {
        Console.WriteLine("Масив чисел:");
        foreach (var number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }

    static void PrintNumbersLessThan15()
    {
        Console.WriteLine("Числа менше 15:");
        lock (lockObject)
        {
            foreach (var number in numbers)
            {
                if (number < 15)
                {
                    Console.Write(number + " ");
                }
            }
            Console.WriteLine();
        }
    }

    static void CalculateGeometricMean()
    {
        double product = 1;
        lock (lockObject)
        {
            foreach (var number in numbers)
            {
                product *= number;
            }
        }

        double geometricMean = Math.Pow(product, 1.0 / numbers.Length);
        Console.WriteLine($"Середнє геометричне: {geometricMean}");
    }
}