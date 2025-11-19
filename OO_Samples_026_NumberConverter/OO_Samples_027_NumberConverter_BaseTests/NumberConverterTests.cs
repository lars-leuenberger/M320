using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter.Tests
{
    [TestClass()]
    public class NumberConverterTests
    {
        NumberConverter converter = new NumberConverter();
        [TestMethod()]
        public void RoundUpTestLow()
        {
            Assert.AreEqual(3, converter.RoundUp(2.3f));
        }
        [TestMethod()]
        public void RoundUpTestHigh()
        {
            Assert.AreEqual(9, converter.RoundUp(8.7f));
        }
    }
}