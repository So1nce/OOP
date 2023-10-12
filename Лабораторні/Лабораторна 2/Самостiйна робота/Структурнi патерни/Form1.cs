namespace Структурнi_патерни
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TargetInterface adapter = new AdapterClass();
            adapter.targetMethod();
        }
    }
}