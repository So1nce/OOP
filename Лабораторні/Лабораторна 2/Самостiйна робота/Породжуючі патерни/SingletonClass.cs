using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Породжуючі_патерни
{
    internal class SingletonClass
    {
        private static SingletonClass instance;

        private SingletonClass() { }

        public static SingletonClass getInstance()
        {
            if (instance == null)
                instance = new SingletonClass();
            return instance;
        }

        public void someMethod()
        {
            MessageBox.Show("Викликано метод someMethod() в класі SingletonClass");
        }
    }
}
