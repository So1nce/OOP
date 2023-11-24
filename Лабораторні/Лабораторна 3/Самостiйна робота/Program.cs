using System.Xml;
using System.Xml.Linq;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("#1 Завдання\n");
        /* 
         * #1 Розробити статичний клас для перетворення наведеного нижче xml документа на об'єкт класу Notepad,
         * що містить список (використовувати контейнер List) об'єктів класу Note. Кількість об'єктів Note у списку не обмежена.
         * Класи Note та Notepad розробити самостійно.
         * 
         * Написати програму, що ілюструє роботу створених класів
         */
        string relativePath = Path.Combine("Data", "file1.xml");
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

        if (File.Exists(filePath))
        {
            string xmlData = File.ReadAllText(filePath);

            Notepad notepad = XmlParse.ParseNotepad(xmlData);
            Console.WriteLine(notepad);
        }

        Console.WriteLine("---------------------------------------------------------------------------------\n");
        Console.WriteLine("#2 Завдання\n");

        /* 
         * #2 Розробити статичний клас для перетворення наведеного нижче xml документа на об'єкт класу Log,
         * що містить список (використовувати контейнер List) об'єктів класу Event. Кількість об'єктів Event у списку не обмежена.
         * Класи Event та Log розробити самостійно.
         * 
         * Написати програму, що ілюструє роботу створених класів.
         */
        relativePath = Path.Combine("Data", "file2.xml");
        filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

        if (File.Exists(filePath))
        {
            string xmlData = File.ReadAllText(filePath);

            Log log = XmlParse.ParseLog(xmlData);
            Console.WriteLine(log);
        }
    }
}