using dublettenfinder.dublettenprüfung;
using dublettenfinder.provider;
using dublettenfinder.usecase;
using dubletttenfinder.ui;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dublettenfinder.app
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // build
            var ui = new Ui();
            var datei_leser = new DateiLeser();
            var hash_generator = new HashGenerator();
            var dubleten_prüfer = new Dublettenprüfer();
            var ergebnis_berechner = new ErgebnisBerechner();
            var use_case = new UseCase(datei_leser, hash_generator, dubleten_prüfer, ergebnis_berechner);

            //start
            var erg = use_case.Dublettenprüfen(args[0], args[1]);
            ui.Ausgabe(erg);
        }
    }
}
