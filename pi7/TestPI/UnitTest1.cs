using System;
using pi;

namespace TestPI
{
    public class Tests
    {
        [Test]
        public void CountSum() // сумма чисел
        {
            Assert.AreEqual(pi.Program.CountSum(5, 10), 15);
            Assert.AreEqual(pi.Program.CountSum(15, 44), 59);
            Assert.AreEqual(pi.Program.CountSum(14, 17), 31);
        }

        [Test]
        public void TheSameParity() // числа одинаковой четности
        {
            Assert.AreEqual(pi.Program.TheSameParity(10, 12), true);
            Assert.AreEqual(pi.Program.TheSameParity(10, 5), false);
            Assert.AreEqual(pi.Program.TheSameParity(14, 18), true);
        }

        [Test]
        public void DifferentParity() // числа разной четности
        {
            Assert.AreEqual(pi.Program.DifferentParity(89, 57), false);
            Assert.AreEqual(pi.Program.DifferentParity(56, 23), true);
            Assert.AreEqual(pi.Program.DifferentParity(13, 11), false);
        }
    }
}