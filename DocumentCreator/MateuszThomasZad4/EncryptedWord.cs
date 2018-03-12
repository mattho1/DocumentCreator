using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace DocumentCreator
{
    public class EncryptedWord
    {
        /// <summary>
        /// Zaszyfrowane słowo.
        /// </summary>
        public string word { get; }
        public EncryptedWord(string word)
        {
            this.word = sha256Encrypt(word);
        }
        /// <summary>
        /// Funkcja szyfrująca słowo podane jako argument funkcji.
        /// </summary>
        /// <param name="phrase"></param>
        /// <returns></returns>
        private static string sha256Encrypt(string phrase)
        {
            UTF8Encoding encoder = new UTF8Encoding();
            SHA256Managed sha256hasher = new SHA256Managed();
            byte[] hashedDataBytes = sha256hasher.ComputeHash(encoder.GetBytes(phrase));
            return byteArrayToString(hashedDataBytes);
        }
        /// <summary>
        /// Funkcja tworząca z tablicy bajtów obiekt klasy string.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        private static string byteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder("");
            for (int i = 0; i < inputArray.Length; i++)
            {
                output.Append(inputArray[i].ToString("X2"));
            }
            return output.ToString();
        }
    }
}
