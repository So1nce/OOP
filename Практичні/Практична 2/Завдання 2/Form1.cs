namespace Завдання_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputString = txtInput.Text;
            string resultString = AddSpacesBeforeLetters(inputString);
            MessageBox.Show("Результат: " + resultString);
        }

        private string AddSpacesBeforeLetters(string inputString)
        {
            // Ініціалізуємо пустий рядок для результату
            string result = "";

            // Переглядаємо кожен символ у вхідному рядку
            foreach (char c in inputString)
            {
                // Додаємо пробіл перед кожною буквою
                if (char.IsLetter(c))
                    result += " ";

                // Додаємо поточний символ
                result += c;
            }

            return result;
        }
    }
}