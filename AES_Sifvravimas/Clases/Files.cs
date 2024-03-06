﻿
namespace AES_Sifvravimas.Clases
{
    internal class Files
    {
        public void saveTextFile(string text)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                {
                    writer.Write(text);
                }
            }
        }

        public string openTextFile()
        {
            string fileContent = string.Empty;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog1.FileName))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                catch
                {
                    MessageBox.Show("Nenuskaitytas failas");
                }
            }

            return fileContent;
        }
    }
}
