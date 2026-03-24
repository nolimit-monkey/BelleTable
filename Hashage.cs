using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BelleTable
{
    public class Hashage
    {
        public Hashage() { }
        public string GenerateSHA256String(string inputString)//SHA256
        {
            SHA256 sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha256.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }
        public string MakeMD5Hash(string input)//MD5
        {
            // etape 1, calculer MD5 depuis la chaine
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // etape 2, concertir vers chaine Hexa
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public string GenerateSHA512String(string inputString)//Sha512
        {
            SHA512 sha512 = SHA512.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);
        }

        private string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }

        public string Salting(string input)
        {
            string result = input;
            char c1 = input[0];
            char c2 = input[1];
            int value1 = Convert.ToInt32(c1.ToString(), 16);
            int value2 = Convert.ToInt32(c2.ToString(), 16);

            int value = value1 + value2;

            string part1 = result.Substring(0, value % result.Length);
            string part2 = result.Substring(value % result.Length);

            int valeur = value1 * 16 + value2; // valeur entre 0 et 255
            string hex = valeur.ToString("X4");

            result = part1 + hex + part2;
            return result;
        }
    }
}
