using dubletttenfinder.ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dublettenfinder.ui.tests
{
    public static class Prüfstand
    {
        static void Main(string[] args)
        {
            var sut = new Ui();
            sut.Ausgabe("Ausgabe Ergebnis");
        }
    }
}
