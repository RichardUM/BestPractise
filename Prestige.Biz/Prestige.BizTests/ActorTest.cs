using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Biz;


namespace Prestige.BizTests
{
    [TestClass]
    public class ActorTest
    {
        [TestMethod]
        public void TestGetOccupation()
        {
          var currentActor = new Actor();
          var expected = "Actor";

          string result = currentActor.GetOccupation();

          Assert.AreEqual(expected,result);
        }
    }
}
