using NUnit.Framework;

namespace MyMath.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        /// <summary>Tests if Add method is working correctly</summary>
        public void Test1()
        {
            int sum = Operations.Add(7, 8);
            Assert.AreEqual(15, sum);
        }
    }
}