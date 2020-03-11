using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prestige.Common;

namespace Prestige.CommonTest
{
    [TestClass]
    public class NotificationServiceTest
    {
        [TestMethod]
        public void TestNotifyTalent()
        {
          var expect = "talent: ray";

          var actual = NotificationService.NotifyTalent("ray");

          Assert.AreEqual(expect,actual);

        }
    }
}
