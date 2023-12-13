using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SharinganSolutions.DataTresCapas.AES
{
    public class Encryptar
    {
        public string EncryptTextWithAES(string plainText, string password)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(password);
                aesAlg.IV = new byte[16];

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(ms, aesAlg.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    byte[] encryptedBytes = ms.ToArray();
                    return Convert.ToBase64String(encryptedBytes); // Convertir los bytes cifrados a una cadena Base64
                }
            }
        }

        public string DecryptTextWithAES(string encryptedText, string password)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(password);
                aesAlg.IV = new byte[16];

                byte[] encryptedBytes = Convert.FromBase64String(encryptedText); // Convertir la cadena Base64 a bytes

                using (MemoryStream ms = new MemoryStream(encryptedBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(ms, aesAlg.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
