using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Behavioral.Strategy
{
    public class SHA384Hashing : HashingStrategy
    {
        public override void HashingInterface(string text)
        {
            SHA384 sha384 = new SHA384CryptoServiceProvider();
            Byte[] bytes;
            bytes = ASCIIEncoding.Default.GetBytes(text);
            Byte[] encodedBytes;
            encodedBytes = sha384.ComputeHash(bytes);
            string A = BitConverter.ToString(encodedBytes);
            Console.WriteLine("SHA384CryptoServiceProvider: "+A);
        }
    }
}
