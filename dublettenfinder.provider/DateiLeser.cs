using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dublettenfinder.provider
{
    public class DateiLeser
    {
        public byte[] Datei_lesen(string datei_pfad)
        {
            return File.ReadAllBytes(datei_pfad);
        }
    }
}
