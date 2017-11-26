using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Strategy
{
    public class MD5Hashing : HashingStrategy
    {
        public override void HashingInterface(string text)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);
            Byte[] encodedBytes;
            encodedBytes = md5.ComputeHash(bytes);
            string A = BitConverter.ToString(encodedBytes);

            Console.WriteLine("MD5CryptoServiceProvider: "+A);
        }
    }
}
