using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dublettenfinder.provider
{
    public class HashGenerator
    {
        private readonly MD5CryptoServiceProvider md5_service = new MD5CryptoServiceProvider();

        public string Hash_bilden(byte[] daten)
        {
            var hash_daten = Hash_lesen(daten);
            return Hash_zu_string_convertieren(hash_daten);
        }

        private byte[] Hash_lesen(byte[] daten)
        {
            return md5_service.ComputeHash(daten);
        }

        private string Hash_zu_string_convertieren(byte[] daten)
        {
            return BitConverter.ToString(daten);
        }
    }
}
