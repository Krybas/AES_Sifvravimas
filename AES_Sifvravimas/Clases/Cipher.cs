using System.Text;
using System.Security.Cryptography;

namespace AES_Sifvravimas.Clases
{
    internal class Cipher
    {


        public string Encrypt(string text, string key, CipherMode mode)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Mode = mode;
                aes.Padding = PaddingMode.PKCS7;

                byte[] Key = Encoding.UTF8.GetBytes(key);

                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(aes.IV, 0, aes.IV.Length);

                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateEncryptor(Key, aes.IV), CryptoStreamMode.Write))
                    {
                        using (StreamWriter sw = new StreamWriter(cs))
                        {
                            sw.Write(text);
                        }
                    }
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        public string Decrypt(string encryptedText, string key, CipherMode mode)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Mode = mode;
                aes.Padding = PaddingMode.PKCS7;

                byte[] Key = Encoding.UTF8.GetBytes(key);
                byte[] encryptedData = Convert.FromBase64String(encryptedText);
                byte[] iv = new byte[aes.IV.Length];

                Array.Copy(encryptedData, iv, iv.Length);

                using (MemoryStream ms = new MemoryStream(encryptedData, iv.Length, encryptedData.Length - iv.Length))
                {
                    using (CryptoStream cs = new CryptoStream(ms, aes.CreateDecryptor(Key, iv), CryptoStreamMode.Read))
                    {
                        using (StreamReader reader = new StreamReader(cs))
                        {
                            return reader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
