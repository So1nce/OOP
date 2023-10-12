namespace Породжуючі_патерни
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingletonClass singleton = SingletonClass.getInstance();
            singleton.someMethod();
        }
    }
}