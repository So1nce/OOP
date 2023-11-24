public class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        TArray array1 = new TArray();
        array1.Input();
        Console.WriteLine("Масив 1:");
        array1.Output();

        TArray array2 = new TArray(new int[] { 1, 2, 3, 4, 5 });
        Console.WriteLine("Масив 2:");
        array2.Output();

        // Тестування знаходження найбільшого та найменшого елемента
        Console.WriteLine($"Максимальний елемент у масиві 1: {array1.FindMax()}");
        Console.WriteLine($"Мінімальний елемент у масиві 2: {array2.FindMin()}");

        // Тестування сортування масиву
        array1.Sort();
        Console.WriteLine("Відсортований масив 1:");
        array1.Output();

        // Тестування знаходження суми елементів
        Console.WriteLine($"Сума елементів у масиві 2: {array2.Sum()}");

        // Тестування перевантажених операторів
        TArray sumArray = array1 + array2;
        Console.WriteLine("Масив 1 + Масив 2:");
        sumArray.Output();

        TArray subtractedArray = array1 - array2;
        Console.WriteLine("Масив 1 - Масив 2:");
        subtractedArray.Output();

        TArray multipliedArray = array1 * 2;
        Console.WriteLine("Масив 1 * 2:");
        multipliedArray.Output();

        // Тестування класу-нащадка
        TOderedArray orderedArray = new TOderedArray(array2);
        orderedArray.AddElement(6);
        Console.WriteLine("Впорядкований масив (після додавання 6):");
        orderedArray.Output();

        orderedArray.RemoveElement(3);
        Console.WriteLine("Впорядкований масив (після вилучення 3):");
        orderedArray.Output();
    }
}