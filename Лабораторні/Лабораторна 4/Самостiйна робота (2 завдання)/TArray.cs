public class TArray
{
    // Поля класу
    public int[] array;
    public int size;

    // Конструктори
    public TArray()
    {
        array = new int[0];
        size = 0;
    }

    public TArray(int[] initialArray)
    {
        array = initialArray;
        size = initialArray.Length;
    }

    // Конструктор копіювання
    public TArray(TArray source)
    {
        array = new int[source.size];
        Array.Copy(source.array, array, source.size);
        size = source.size;
    }

    // Метод для введення даних
    public void Input()
    {
        Console.WriteLine("Введіть розмір масиву:");
        size = int.Parse(Console.ReadLine());

        array = new int[size];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Елемент {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    // Метод для виведення даних
    public void Output()
    {
        Console.WriteLine("Елементи масиву:");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    // Метод для знаходження найбільшого елемента
    public int FindMax()
    {
        int max = array[0];
        for (int i = 1; i < size; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }

    // Метод для знаходження найменшого елемента
    public int FindMin()
    {
        int min = array[0];
        for (int i = 1; i < size; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }

    // Метод для сортування масиву
    public void Sort()
    {
        Array.Sort(array);
    }

    // Метод для знаходження суми елементів
    public int Sum()
    {
        int sum = 0;
        foreach (var element in array)
        {
            sum += element;
        }
        return sum;
    }

    // Перевантаження операторів
    public static TArray operator +(TArray a, TArray b)
    {
        int[] resultArray = new int[a.size];
        for (int i = 0; i < a.size; i++)
        {
            resultArray[i] = a.array[i] + b.array[i];
        }
        return new TArray(resultArray);
    }

    public static TArray operator -(TArray a, TArray b)
    {
        int[] resultArray = new int[a.size];
        for (int i = 0; i < a.size; i++)
        {
            resultArray[i] = a.array[i] - b.array[i];
        }
        return new TArray(resultArray);
    }

    public static TArray operator *(TArray a, int scalar)
    {
        int[] resultArray = new int[a.size];
        for (int i = 0; i < a.size; i++)
        {
            resultArray[i] = a.array[i] * scalar;
        }
        return new TArray(resultArray);
    }
}