using FactorialProject;

namespace FactorialTest
{
    [TestClass]
    public class FactorialTest
    {
        [TestMethod]
        public void TestMinusNumber()
        {
            long i = -1;
            try { long result = Factorial.Calculate(i); }
            catch (Exception ex) { Assert.AreEqual(typeof(ArgumentOutOfRangeException), ex.GetType()); }
        }
        [TestMethod]
        public void TestBigNumber()
        {
            var i = 120;
            try { long result = Factorial.Calculate(i); }
            catch (Exception ex) { Assert.AreEqual(typeof(ArgumentOutOfRangeException), ex.GetType()); }
        }

        [TestMethod]
        public void TestNormalNumber()
        {
            var i = 5;
            long result = Factorial.Calculate(i);
            Assert.AreEqual(120, result);
        }
    }
}