using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Поведiнковi_патерни
{
    internal class ConcreteCommand : ICommand
    {
        private Receiver receiver;

        public ConcreteCommand(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public void Execute()
        {
            receiver.Action();
        }
    }
}
