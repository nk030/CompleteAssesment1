using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Assignment1.Test
{
    [TestClass]
    public class testing2
    {
        Logicclass Logic = new Logicclass();
        [TestMethod]
        public void ShootAway()
        {
            int testint = Logic.Shootaway();
            Assert.IsTrue();
        }
        private int ShootAway()
        {
            throw new NotImplementedException();
        }

    }
    }
}
