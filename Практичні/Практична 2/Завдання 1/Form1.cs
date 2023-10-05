namespace Завдання_1
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
            int count = CountPlusSymbols(inputString);
            MessageBox.Show("Кількість символів '+' до першій комі: " + count);
        }

        private int CountPlusSymbols(string inputString)
        {
            int count = 0;

            // Проверка наличия комы в строке
            int commaIndex = inputString.IndexOf(',');
            if (commaIndex != -1)
            {
                // Подсчет символов '+' до первой комы
                for (int i = 0; i < commaIndex; i++)
                {
                    if (inputString[i] == '+')
                        count++;
                }
            }

            return count;
        }
    }
}