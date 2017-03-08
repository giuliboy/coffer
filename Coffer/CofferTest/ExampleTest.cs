using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CofferTest
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExampleTestMethod()
        {
            throw new ArgumentOutOfRangeException("bumm");
        }
    }
}
