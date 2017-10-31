using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dublettenfinder.dublettenprüfung.tests
{
    [TestClass]
    public class DublettenprüferTests
    {
        Dublettenprüfer sut;

        [TestInitialize]
        public void Init()
        {
            sut = new Dublettenprüfer();
        }

        [TestMethod]
        public void Hashes_sind_gleich()
        {
            var erg = sut.Hashes_auf_gleichheit_prüfen("AF-6C-6C-F7-A4-54-B4-EF-4A-85-0A-C4-D9-60-A2-CC", 
                                                       "AF-6C-6C-F7-A4-54-B4-EF-4A-85-0A-C4-D9-60-A2-CC");
            Assert.AreEqual(true, erg);
        }

        [TestMethod]
        public void Hashes_sind_nicht_gleich()
        {
            var erg = sut.Hashes_auf_gleichheit_prüfen("AF-6C-6C-F7-A4-54-A4-EF-4A-85-0A-C4-D9-60-A2-CC",
                                                       "AF-6C-6C-F7-A4-54-B4-EF-4A-85-0A-C4-D9-60-A2-CC");
            Assert.AreEqual(false, erg);
        }

        [TestCleanup]
        public void CleanUp()
        {
            sut = null;
        }
    }
}
