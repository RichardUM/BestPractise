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

      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestParameterizedConstactor()
    {
      var currentActor = new Actor("Jonny");
      var expected = "Jonny";

      string result = currentActor.ActorName;

      Assert.AreEqual(expected,result);
    }

    [TestMethod]
    public void TestBookActor()
    {
      string details = "Bookings can Change if " +
                       "actor starts trouble";
      var currentActor =  new Actor("Jonny Boi");
      var expected = $"Actor Jonny Boi is booked. {details}";

      string result = currentActor.BooKActor();

      Assert.AreEqual(expected,result);
    }
  }
}
