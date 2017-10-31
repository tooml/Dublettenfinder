using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dublettenfinder.dublettenprüfung
{
    public class ErgebnisBerechner
    {
        public string Ergebnis_Text_bilden(bool ergebnis)
        {
            switch (ergebnis)
            {
                case true: return "Datein sind gleich.";
                case false: return "Datein sind nicht gleich.";
                default: throw new ArgumentNullException();
            }
        }
    }
}
