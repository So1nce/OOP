using System.Xml.Serialization;

namespace Практична_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML файли (*.xml)|*.xml|Всі файли (*.*)|*.*";
            openFileDialog.Title = "Вибрати XML файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;
                DisplayXmlFileContent(selectedFileName);
            }
        }

        private void DisplayXmlFileContent(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string xmlContent = reader.ReadToEnd();
                    txtXmlContent.Text = xmlContent;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка читання XML файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSaveXml_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "XML файли (*.xml)|*.xml|Всі файли (*.*)|*.*";
                saveFileDialog.Title = "Зберегти як XML файл";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = saveFileDialog.FileName;
                    SerializeToXml(txtInputText.Text, selectedFileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження XML файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SerializeToXml(string textToSerialize, string fileName)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(string));
                using (StreamWriter writer = new StreamWriter(fileName))
                {
                    serializer.Serialize(writer, textToSerialize);
                }

                MessageBox.Show("Серіалізація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка під час серіалізації: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
