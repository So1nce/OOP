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
            string login = LoginTextBox.Text;

            if (IsLoginValid(login))
                ResultLabel.Text = "Логін коректний.";
            else
                ResultLabel.Text = "Логін некоректний.";
        }

        private bool IsLoginValid(string login)
        {
            // Перевірка довжини логіна
            if (login.Length < 2 || login.Length > 10)
                return false;

            // Перевірка першого символу на букву
            if (!char.IsLetter(login[0]))
                return false;

            // Перевірка, чи містить логін тільки літери та цифри
            foreach (char c in login)
            {
                if (!char.IsLetterOrDigit(c))
                    return false;
            }

            return true;
        }
    }
}