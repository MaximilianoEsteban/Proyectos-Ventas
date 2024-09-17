using System.IO;
using System.Security.Cryptography;
using System.Text;
using System;

namespace Carrefour.BackEnd.Helpers
{
    public class AESEncrypter
    {
        private byte[] key;
        private const string seedKey = "CARREFOUR";
        private const int blockSize = 256;
        private const CipherMode cipherMode = CipherMode.CFB;
        private const PaddingMode paddingMode = PaddingMode.Zeros;

        /** Encriptacion Aes128 Standard **/
        private const string aes128SeedKey = "5fcf26c96a155909";
        private const int aes128BlockSize = 128;
        private const CipherMode aes128CipherMode = CipherMode.CBC;
        private const PaddingMode aes128PaddingMode = PaddingMode.PKCS7;
        /** --------------------------- **/

        public AESEncrypter()
        {
            string codifyString = System.Convert.ToBase64String((new SHA512CryptoServiceProvider()).ComputeHash(Encoding.UTF8.GetBytes(seedKey))).Substring(0, 32);
            key = Encoding.UTF8.GetBytes(codifyString);
        }

        public string Encrypt128Base64UrlEncode(string plainText)
        {
            var aes128Key = Encoding.UTF8.GetBytes(aes128SeedKey);
            if (plainText == null || plainText.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }

            byte[] encrypted;
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.KeySize = aes128BlockSize;
                rijAlg.Key = aes128Key;
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.IV = new byte[16];

                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);
                var bytes = Encoding.UTF8.GetBytes(plainText);
                encrypted = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(plainText), 0, bytes.Length);
            }

            string base64 = Convert.ToBase64String(encrypted);
            string urlFriendlyBase64 = base64.Replace("+", ".").Replace("/", "_").Replace("=", "-");

            return System.Web.HttpUtility.UrlEncode(urlFriendlyBase64);
        }

        public string Decrypt128Base64UrlEncode(string encryptedEncoded)
        {
            string encrypted = System.Web.HttpUtility.UrlDecode(encryptedEncoded);
            return Decrypt128Base64(encrypted);
        }

        public string Decrypt128Base64(string encrypted)
        {
            var aes128Key = Encoding.UTF8.GetBytes(aes128SeedKey);
            string plainText = string.Empty;
            if (encrypted == null || encrypted.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }

            string pureBase64 = encrypted.Replace(".", "+").Replace("_", "/").Replace("-", "=");
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.KeySize = aes128BlockSize;
                rijAlg.Key = aes128Key;
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.IV = new byte[16];

                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);
                using (var msDecrypt = new MemoryStream(Convert.FromBase64String(pureBase64)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new StreamReader(csDecrypt))
                {
                    plainText = srDecrypt.ReadToEnd();
                }
            }

            return plainText;
        }

        public string Encrypt(string plainText)
        {
            var aes128Key = Encoding.UTF8.GetBytes(aes128SeedKey);
            if (plainText == null || plainText.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }

            byte[] encrypted;
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.KeySize = aes128BlockSize;
                rijAlg.Key = aes128Key;
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.IV = new byte[16];

                ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);
                var bytes = Encoding.UTF8.GetBytes(plainText);
                encrypted = encryptor.TransformFinalBlock(Encoding.UTF8.GetBytes(plainText), 0, bytes.Length);
            }

            string base64 = Convert.ToBase64String(encrypted);
            string urlFriendlyBase64 = base64.Replace("+", ".").Replace("/", "_").Replace("=", "-");

            return System.Web.HttpUtility.UrlEncode(urlFriendlyBase64);
        }

        //public string Decrypt128Base64UrlEncode(string encryptedEncoded)
        //{
        //    string encrypted = System.Web.HttpUtility.UrlDecode(encryptedEncoded);
        //    return Decrypt128Base64(encrypted);
        //}

        public string Decrypt(string encrypted)
        {
            var aes128Key = Encoding.UTF8.GetBytes(aes128SeedKey);
            string plainText = string.Empty;
            if (encrypted == null || encrypted.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }

            string pureBase64 = encrypted.Replace(".", "+").Replace("_", "/").Replace("-", "=");
            using (var rijAlg = new RijndaelManaged())
            {
                rijAlg.KeySize = aes128BlockSize;
                rijAlg.Key = aes128Key;
                rijAlg.Mode = CipherMode.CBC;
                rijAlg.Padding = PaddingMode.PKCS7;
                rijAlg.IV = new byte[16];

                ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);
                using (var msDecrypt = new MemoryStream(Convert.FromBase64String(pureBase64)))
                using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                using (var srDecrypt = new StreamReader(csDecrypt))
                {
                    plainText = srDecrypt.ReadToEnd();
                }
            }

            return plainText;
        }


        private static string ByteArrayToHexViaLookup32(byte[] bytes)
        {
            var lookup32 = _lookup32;
            var result = new char[bytes.Length * 2];
            for (int i = 0; i < bytes.Length; i++)
            {
                var val = lookup32[bytes[i]];
                result[2 * i] = (char)val;
                result[2 * i + 1] = (char)(val >> 16);
            }
            return new string(result);
        }

        private static readonly uint[] _lookup32 = CreateLookup32();

        private static uint[] CreateLookup32()
        {
            var result = new uint[256];
            for (int i = 0; i < 256; i++)
            {
                string s = i.ToString("X2");
                result[i] = ((uint)s[0]) + ((uint)s[1] << 16);
            }
            return result;
        }


        public static byte[] StringToByteArrayFastest(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");

            byte[] arr = new byte[hex.Length >> 1];

            for (int i = 0; i < hex.Length >> 1; ++i)
            {
                arr[i] = (byte)((GetHexVal(hex[i << 1]) << 4) + (GetHexVal(hex[(i << 1) + 1])));
            }

            return arr;
        }

        public static int GetHexVal(char hex)
        {
            int val = (int)hex;
            //For uppercase A-F letters:
            return val - (val < 58 ? 48 : 55);
            //For lowercase a-f letters:
            //return val - (val < 58 ? 48 : 87);
            //Or the two combined, but a bit slower:
            //return val - (val < 58 ? 48 : (val < 97 ? 55 : 87));
        }

    }
}
