using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MCD;

namespace MCD.Tests
{
    [TestClass]
    public class MCDTests
    {
        [TestMethod]
        public void TestCalcularMCD()
        {
            MCD mcd = new MCD();
            Assert.AreEqual(mcd.CalcularMCD(12, 18), 6);
            Assert.AreEqual(mcd.CalcularMCD(8, 16), 8);
            Assert.AreEqual(mcd.CalcularMCD(5, 10), 5);
        }

        [TestMethod]
        public void TestCalcularMCD_CuatroNumeros()
        {
            MCD mcd = new MCD();
            Assert.AreEqual(mcd.CalcularMCD_CuatroNumeros(12, 18, 24, 36), 6);
            Assert.AreEqual(mcd.CalcularMCD_CuatroNumeros(8, 16, 32, 64), 8);
            Assert.AreEqual(mcd.CalcularMCD_CuatroNumeros(5, 10, 15, 20), 5);
        }
    }
}
