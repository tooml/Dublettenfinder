using dublettenfinder.dublettenprüfung;
using dublettenfinder.provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dublettenfinder.usecase
{
    public class UseCase
    {
        private readonly DateiLeser _datei_leser;
        private readonly HashGenerator _hash_generator;
        private readonly Dublettenprüfer _dubleten_prüfer;
        private readonly ErgebnisBerechner _ergebnis_berechner;

        public UseCase(DateiLeser datei_leser, HashGenerator hash_generator,
                            Dublettenprüfer dubleten_prüfer, ErgebnisBerechner ergebnis_berechner)
        {
            _datei_leser = datei_leser;
            _hash_generator = hash_generator;
            _dubleten_prüfer = dubleten_prüfer;
            _ergebnis_berechner = ergebnis_berechner;
        }

        public string Dublettenprüfen(string datei_pfad_eins, string datei_pfad_zwei)
        {
            var datei_eins = _datei_leser.Datei_lesen(datei_pfad_eins);
            var datei_zwei = _datei_leser.Datei_lesen(datei_pfad_zwei);

            var hash_datei_eins = _hash_generator.Hash_bilden(datei_eins);
            var hash_datei_zwei = _hash_generator.Hash_bilden(datei_zwei);

            var ergebnis = _dubleten_prüfer.Hashes_auf_gleichheit_prüfen(hash_datei_eins, hash_datei_zwei);
            return _ergebnis_berechner.Ergebnis_Text_bilden(ergebnis);
        }
    }
}
