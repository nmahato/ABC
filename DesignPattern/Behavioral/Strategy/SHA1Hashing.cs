using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Strategy
{
    public class SHA1Hashing : HashingStrategy
    {
        public override void HashingInterface(string text)
        {
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);
            Byte[] encodedBytes;
            encodedBytes = sha1.ComputeHash(bytes);
            string A = BitConverter.ToString(encodedBytes);
             Console.WriteLine("SHA1CryptoServiceProvider: "+A);
        }
    }
}
