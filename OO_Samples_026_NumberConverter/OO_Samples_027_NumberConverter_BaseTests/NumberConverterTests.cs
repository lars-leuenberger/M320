using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberConverter;
using OO_Samples_027_NumberConverter_Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberConverter.Tests
{
    IStringConverterDummy converter = new NumberConverterDummy();
    [TestClass()]
    public class NumberConverterTests
    {
        
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