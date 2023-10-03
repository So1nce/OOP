using System.Text.RegularExpressions;

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
            string inputText = InputTextBox.Text;

            // Слова для заміни та їх нові значення
            var replacementWords = new Dictionary<string, string>
            {
                {"бесіду", "розмову"},
                {"бесіда", "розмова"},
                {"бесіди", "розмови"},
                {"бесіді", "розмові"},
                {"бесідах", "розмовах"},
                {"бесідою", "розмовою"},
                {"бесідами", "розмовами"}
            };

            // Побудова регулярного виразу для знаходження слів
            string pattern = @"\b(" + string.Join("|", replacementWords.Keys) + @")\b";

            // Заміна слів у введеному тексті
            string resultText = Regex.Replace(inputText, pattern, match =>
            {
                string matchedWord = match.Groups[1].Value;
                return replacementWords.ContainsKey(matchedWord) ? replacementWords[matchedWord] : matchedWord;
            });

            // Виведення результату
            ResultTextBox.Text = resultText;
        }
    }
}