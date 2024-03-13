using AES_Sifvravimas.Clases;
using System.Security.Cryptography;
using System.Text;

namespace AES_Sifvravimas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Cipher cipher = new Cipher();
        Files file = new Files();

        private void Encryption()
        {
            string selectedMode = comboBoxMode.SelectedItem.ToString();
            switch (selectedMode)
            {
                case "ECB":
                    string ECB = cipher.Encrypt(txtBoxText.Text, txtBoxKey.Text, CipherMode.ECB);
                    txtBoxResult.Text = ECB;
                    break;
                case "CBC":
                    string CBC = cipher.Encrypt(txtBoxText.Text, txtBoxKey.Text, CipherMode.CBC);
                    txtBoxResult.Text = CBC;
                    break;
                case "CFB":
                    string CFB = cipher.Encrypt(txtBoxText.Text, txtBoxKey.Text, CipherMode.CFB);
                    txtBoxResult.Text = CFB;
                    break;
                default:
                    MessageBox.Show("Nepasirinkote modo");
                    break;

            }

        }
        private void Decryption(string encrypted)
        {
            string selectedMode = comboBoxMode.SelectedItem.ToString();
            switch (selectedMode)
            {
                case "ECB":
                    string ECB = cipher.Decrypt(encrypted, txtBoxKey.Text, CipherMode.ECB);
                    txtBoxResult.Text = ECB;
                    break;
                case "CBC":
                    string CBC = cipher.Decrypt(encrypted, txtBoxKey.Text, CipherMode.CBC);
                    txtBoxResult.Text = CBC;
                    break;
                case "CFB":
                    string CFB = cipher.Decrypt(encrypted, txtBoxKey.Text, CipherMode.CFB);
                    txtBoxResult.Text = CFB;
                    break;
                default:
                    MessageBox.Show("Nepasirinkote modo");
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool check = chechTextBox();
            if (check)
            {
                string value = comboBox.SelectedItem.ToString();
                switch (value)
                {
                    case "Uþsifruoti":
                        Encryption();
                        break;
                    case "Deðifruoti":
                        Decryption(txtBoxResult.Text);
                        break;
                    default:
                        MessageBox.Show("Nepasirinkote ðifvravimo");
                        break;
                }
            }

        }
        private bool chechTextBox()
        {
            if (txtBoxText.Text == "")
            {
                MessageBox.Show("Iveskite tekstà");
                return false;
            }
            if (txtBoxKey.Text.Length != 16)
            {
                MessageBox.Show("Iveskite raktà, kurio ilgis 16 simboliø");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            file.saveTextFile(txtBoxResult.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            txtBoxText.Text = file.openTextFile();
        }
    }
}
