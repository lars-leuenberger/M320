using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack.Tests
{
    [TestClass()]
    public class StringStackTests
    {
        [TestMethod()]
        public void PushTest()
        {
            StringStack.MyStack(10);
            StringStack.Push("Wert 1");
            StringStack.Push("Wert 2");
            StringStack.Push("Wert 3");
        }

        [TestMethod()]
        public void PopTest()
        {
            StringStack.Pop();
        }

        [TestMethod()]
        public void PeakTest()
        {
            StringStack.Peak();
        }
    }
}