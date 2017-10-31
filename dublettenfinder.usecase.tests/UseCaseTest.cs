using dublettenfinder.dublettenprüfung;
using dublettenfinder.provider;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dublettenfinder.usecase.tests
{
    [TestClass]
    public class UseCaseTest
    {
        UseCase sut;

        [TestInitialize]
        public void Init()
        {
            var datei_leser = new DateiLeser();
            var hash_generator = new HashGenerator();
            var dubleten_prüfer = new Dublettenprüfer();
            var ergebnis_berechner = new ErgebnisBerechner();

            sut = new UseCase(datei_leser, hash_generator, dubleten_prüfer, ergebnis_berechner);
        }

        [TestMethod]
        public void Zwei_unterschiedliche_Dateien()
        {
            var erg = sut.Dublettenprüfen(@"testdateien\Datei_eins.txt", @"testdateien\Datei_drei.txt");
            Assert.AreEqual("Datein sind nicht gleich.", erg);
        }

        [TestMethod]
        public void Zwei_gleiche_Dateien()
        {
            var erg = sut.Dublettenprüfen(@"testdateien\Datei_eins.txt", @"testdateien\Datei_zwei.txt");
            Assert.AreEqual("Datein sind gleich.", erg);
        }

        [TestCleanup]
        public void CleanUp()
        {
            sut = null;
        }
    }
}
