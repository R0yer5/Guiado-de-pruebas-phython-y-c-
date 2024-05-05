using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MCD.Tests
{
    [TestClass]
    public class MCDTests
    {
        [TestMethod]
        public void TestMCD_CuatroNumeros()
        {
            Assert.AreEqual(MCD_CuatroNumeros(12, 18, 24, 36), 6);
            Assert.AreEqual(MCD_CuatroNumeros(8, 16, 32, 64), 8);
            Assert.AreEqual(MCD_CuatroNumeros(5, 10, 15, 20), 5);
        }

        public int MCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public int MCD_CuatroNumeros(int num1, int num2, int num3, int num4)
        {
            int mcd1 = MCD(num1, num2);
            int mcd2 = MCD(num3, num4);
            return MCD(mcd1, mcd2);
        }
    }
}
