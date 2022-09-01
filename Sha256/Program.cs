using System;
using System.Security.Cryptography;
using System.Text;

namespace Sha256
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var sha = SHA256.Create())
            {
                var bytes = Encoding.UTF8.GetBytes("girassol2022");
                var hash = sha.ComputeHash(bytes);


                var result =  Convert.ToBase64String(hash);
            }
        }
    }
}
