using System.Drawing;

public class TOderedArray : TArray
{
    // Конструктори
    public TOderedArray() : base() { }

    public TOderedArray(int[] initialArray) : base(initialArray) { }

    public TOderedArray(TArray source) : base(source) { }

    // Метод для додавання елемента
    public void AddElement(int element)
    {
        int[] newArray = new int[size + 1];
        Array.Copy(array, newArray, size);
        newArray[size] = element;
        array = newArray;
        size++;
        Sort(); // Після додавання впорядковуємо масив
    }

    // Метод для вилучення елемента
    public void RemoveElement(int element)
    {
        int index = Array.IndexOf(array, element);
        if (index != -1)
        {
            int[] newArray = new int[size - 1];
            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index + 1, newArray, index, size - index - 1);
            array = newArray;
            size--;
        }
        Sort(); // Після вилучення впорядковуємо масив
    }

    // Перевизначення операторів
    public static TOderedArray operator +(TOderedArray a, TOderedArray b)
    {
        int[] resultArray = new int[a.size + b.size];
        Array.Copy(a.array, resultArray, a.size);
        Array.Copy(b.array, 0, resultArray, a.size, b.size);
        return new TOderedArray(resultArray);
    }

    public static TOderedArray operator -(TOderedArray a, TOderedArray b)
    {
        int[] resultArray = new int[a.size];
        Array.Copy(a.array, resultArray, a.size);
        foreach (var element in b.array)
        {
            resultArray = Array.FindAll(resultArray, x => x != element);
        }
        return new TOderedArray(resultArray);
    }
}