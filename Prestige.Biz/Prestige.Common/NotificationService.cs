using System;

namespace Prestige.Common
{
  static public class NotificationService
  {
    /// <summary>
    /// Notifies Talent 
    /// </summary>
    /// <param name="talent"></param>
    /// <returns></returns>
    static public string NotifyTalent(string talent)
    {
      var message = "talent: " + talent;
      Console.WriteLine(message);
      return message;

    }
  }
}
