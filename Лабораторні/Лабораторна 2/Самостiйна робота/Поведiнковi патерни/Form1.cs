namespace Поведiнковi_патерни
{
    public partial class Form1 : Form
    {
        private Invoker invoker;

        public Form1()
        {
            InitializeComponent();
            invoker = new Invoker();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Receiver receiver = new Receiver();
            ConcreteCommand command = new ConcreteCommand(receiver);
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}