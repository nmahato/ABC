using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Strategy
{
    public class SHA256Hashing : HashingStrategy
    {
        public override void HashingInterface(string text)
        {
            SHA256 sha256 = new SHA256CryptoServiceProvider();
            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);
            Byte[] encodedBytes;
            encodedBytes = sha256.ComputeHash(bytes);
            string A = BitConverter.ToString(encodedBytes);

             Console.WriteLine("SHA256CryptoServiceProvider: "+A);
        }
    }
}
