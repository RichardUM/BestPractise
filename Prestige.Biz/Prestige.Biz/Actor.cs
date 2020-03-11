using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestige.Biz
{
  public class Actor
  {
    public Actor()
    {
      Console.WriteLine("Something new");
    }

    public Actor(string actorName)
    {
      ActorName = actorName;
    }

    private string actorName;

    public string ActorName
    {
      get { return actorName;}
      set { actorName = value; }
    }
    private string jobTitle;

    public string JobTitle
    {
      get { return jobTitle; }
      set { jobTitle = value; }
    }
    /// <summary>
    /// Will return title
    /// </summary>
    /// <returns></returns>
    public string GetOccupation()
    {
      jobTitle = "Actor";
      return jobTitle;
    }


    /// <summary>
    /// Books actor and not specified date.
    /// </summary>
    /// <returns></returns>
    public string BooKActor()
    {
      string details = "Bookings can Change if " +
                       "actor starts trouble";
      return "Actor " + ActorName + " is booked. " + details;
    }

    /// <summary>
    /// Books actor on specific dates
    /// </summary>
    /// <param name="date"></param>
    /// <returns></returns>
    public string BooKActor(string date)
    {
      string details = "Bookings can Change if " +
                       "actor starts trouble";
      return $"Actor {ActorName} is booked on {date}. {details}";
    }


    }
}
