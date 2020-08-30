using System;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Linq;

namespace EHR
{
    public  class Protect
    {

       
        public static string Encrypt(string word)
        {
            string enText = "";
            while(word.Length%4 != 0)
            {
                word =  word + "`";
            }
            enText = word;
            string hash = "tfs@gtTbGJ^%jskA";
            string encrypted;
            byte[] data = UTF8Encoding.UTF8.GetBytes(enText);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7})
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    encrypted = Convert.ToBase64String(results, 0, results.Length);
                }
            }
            return encrypted;
        }

        public static string Decrypt(string enText)
        {
             
            
            
            string hash = "tfs@gtTbGJ^%jskA";
            string decrypted;
            byte[] data = Convert.FromBase64String(enText);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    decrypted = UTF8Encoding.UTF8.GetString(results);
                }
            }
            string deText = decrypted.TrimEnd('`');
            return deText;
        }
    }
}