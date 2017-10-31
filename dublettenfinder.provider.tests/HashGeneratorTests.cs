using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dublettenfinder.provider.tests
{
    [TestClass]
    public class HashGeneratorTests
    {
        [TestMethod]
        public void Bytes_zu_Hash_Convertieren()
        {
            //Testdaten = "Dot"
            var sut = new HashGenerator();
            var erg = sut.Hash_bilden(new byte[] { 68, 111, 116 });
            Assert.AreEqual("AF-6C-6C-F7-A4-54-B4-EF-4A-85-0A-C4-D9-60-A2-CC", erg);
        }
    }
}
