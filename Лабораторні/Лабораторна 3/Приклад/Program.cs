using System.Diagnostics;
using System.Reflection;
using System.Xml;
using System.Xml.Serialization;
using Приклад;

class Program
{
    static void Main(string[] args)
    {
        XmlDocument xml = new XmlDocument();
        string relativePath = Path.Combine("Data", "XMLFile1.xml");
        string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);
        xml.Load(fullPath);
        foreach (XmlNode node in xml.DocumentElement)
        {
            string id = node.Attributes[0].InnerText;
            string model = node["model"].InnerText;
            int year = Int32.Parse(node["year"].InnerText);
            int price = Int32.Parse(node["price"].InnerText);
            Cars.Add(new Shop(id, model, year, price));
        }
        Cars.Show();
    }
}