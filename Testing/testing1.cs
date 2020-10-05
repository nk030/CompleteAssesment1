using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace/* Assignment1.Test*/
{
    [TestClass]
    public class Logicclass
    {
        Logicclass Logic = new Logicclass();

        [TestMethod]
        public void SpinTesting()
        {
            int testint = Logic.button1();
            Assert.IsTrue();
        }

        private int button1()
        {
            throw new NotImplementedException();
        }
    }
}
