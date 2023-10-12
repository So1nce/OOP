using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Структурнi_патерни
{
    internal class AdapterClass : TargetInterface
    {
        private AdapteeClass adaptee;

        public AdapterClass()
        {
            adaptee = new AdapteeClass();
        }

        public void targetMethod()
        {
            adaptee.specificMethod();
        }
    }
}
