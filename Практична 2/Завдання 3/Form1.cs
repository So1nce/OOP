namespace Завдання_3
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
            int maxWordLength = Convert.ToInt32(txtMaxWordLength.Text);
            string[] words = sentence.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            string filteredWords = FilterWordsByLength(words, maxWordLength);
            MessageBox.Show("Результат: " + filteredWords);
        }

        private string FilterWordsByLength(string[] words, int maxWordLength)
        {
            var filteredWords = words.Where(word => word.Length < maxWordLength);
            return string.Join(" ", filteredWords);
        }
    }
}