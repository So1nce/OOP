using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Приклад
{
    internal class Cars
    {
        public static List<Shop> CarsList = new List<Shop> ();
        public static void Add(Shop s)
        {
            CarsList.Add (s);
        }
        public static void Show()
        {
            foreach(Shop i in CarsList) { i.PrintToConsole(); }
        }
    }
}
