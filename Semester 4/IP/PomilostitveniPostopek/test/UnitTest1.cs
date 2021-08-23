using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PomilostitveniPostopek;

namespace test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PreveriProšnje()
        {
            Prošnja pro1 = new Prošnja(@"C:\Users\Primoz\Documents\CODE\IP\PomilostitveniPostopek\PomilostitveniPostopek\Prošnje\Prošnja1.txt");
            Assert.AreEqual(pro1.Sodišče, StanjaProšnje.ČakaPostopek);

        }
    }
}
