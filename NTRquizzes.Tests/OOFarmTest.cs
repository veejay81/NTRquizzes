using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NTRquizzes.Tests
{
    [TestClass]
    public class OOFarmTest
    {
        /// <summary>
        /// HINT: In order to make this test pass you should use some OO techniques, specially polymorphism
        /// HINT: This file MUST NOT be modified
        /// </summary>
        [TestMethod]
        public void FarmTest()
        {
            var f = new OOFarm(2, 1, 2);
            Assert
                .AreEqual("miau 4 false, miau 4 false, guau 4 false, cuac 2 true, cuac 2 true"
                          , f.IntroduceEverybody());
        }
    }
}
