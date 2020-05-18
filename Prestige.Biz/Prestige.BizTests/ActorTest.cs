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
      //Arrange
      var currentActor = new Actor();
      var expected = "Actor";
      //Act
      string result = currentActor.GetOccupation();
      //Assert
      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestParameterizedConstractor()
    {
      var currentActor = new Actor("Jonny");
      var expected = "Jonny";

      string result = currentActor.ActorName;

      Assert.AreEqual(expected, result);
    }
    [TestMethod]
    public void TestSettingObjectProperty()
    {
      var currentActor = new Actor();
      currentActor.ActorName = "Jonny";
      var expected = "Jonny";

      string result = currentActor.ActorName;

      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestBookActor()
    {
      string details = "Bookings can Change if " +
                       "actor starts trouble";
      var currentActor = new Actor("Jonny Boi");
      var expected = $"Actor Jonny Boi is booked. {details}";

      string result = currentActor.BooKActor();

      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestBookActorOnSpecificDate()
    {
      string details = "Bookings can Change if " +
                       "actor starts trouble";
      var currentActor = new Actor("Jonny Boi");
      var expected = $"Actor Jonny Boi is booked on {DateTime.Today.ToShortDateString()}. {details}";

      string result = currentActor.BooKActor(DateTime.Today.ToShortDateString());

      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestFormattingOnSetterForBookActor()
    {
      string details = "Bookings can Change if " +
                       "actor starts trouble";
      var currentActor = new Actor("Jonny Boi     ");
      var expected = $"Actor Jonny Boi is booked. {details}";

      string result = currentActor.BooKActor();

      Assert.AreEqual(expected, result);
    }

    [TestMethod]
    public void TestAutoPropActorDescription()
    {
      var currentActor = new Actor(){ActorName = "Sandy Love"};
      var expected = "Regular actor";

      var results = currentActor.ActorDescription;

      Assert.AreEqual(expected,results);

    }

    [TestMethod]
    public void TestGetAgency()
    {
      var currentActor = new Actor();
      var expected = "Prestige Talent";

      var result = currentActor.GetAgency();

      Assert.AreEqual(expected, result);
    }
  }

}
