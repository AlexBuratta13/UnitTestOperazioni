using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calc_Library;

namespace Calc_LibraryTests
{
    [TestClass]
    public class LibraryTests
    {
        [TestMethod]
            public void PositiveSum()
            {
                int num1 = 3;
                int num2 = 4;
                int somma_aspettata = 7;
                int somma = Calc.Sum(num1, num2);
                Assert.AreEqual(somma_aspettata, somma);
            }
        [TestMethod]
        public void PositiveDivision()
        {
            int num1 = 3;
            int num2 = 0;
            int divisione_aspettata = 0;
            int divisione = Calc.Division(num1, num2);
            Assert.AreEqual(divisione_aspettata, divisione);
        }
        [TestMethod]
        public void NegativeSum()
        {
            int num1 = -3;
            int num2 = -5;
            int somma_aspettata = -8;
            int somma = Calc.Sum(num1, num2);
            Assert.AreEqual(somma_aspettata, somma);
        }
    }
}
