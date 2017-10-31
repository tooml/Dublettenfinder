using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dublettenfinder.dublettenprüfung
{
    public class Dublettenprüfer
    {
        public bool Hashes_auf_gleichheit_prüfen(string daten_eins, string daten_zwei)
        {
            return (daten_eins.Equals(daten_zwei));
        }
    }
}
