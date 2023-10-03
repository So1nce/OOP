namespace Завдання_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sentence = txtSentence.Text;
            string transformedSentence = TransformSentence(sentence);
            MessageBox.Show("Результат: " + transformedSentence);
        }

        private string TransformSentence(string sentence)
        {
            char[] separators = { ' ', '.', ',', '!', '?' };
            string[] words = sentence.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string transformedSentence = "";
            foreach (string word in words)
            {
                if (IsVowel(word[0]))
                    transformedSentence += word + ",";
                else
                    transformedSentence += word + "!";
                transformedSentence += " ";
            }

            return transformedSentence.Trim();
        }

        private bool IsVowel(char c)
        {
            char[] vowels = { 'А', 'Е', 'Є', 'И', 'І', 'Ї', 'О', 'У', 'Ю', 'Я', 'а', 'е', 'є', 'и', 'і', 'ї', 'о', 'у', 'ю', 'я', 'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u' };
            return Array.IndexOf(vowels, c) != -1;
        }
    }
}