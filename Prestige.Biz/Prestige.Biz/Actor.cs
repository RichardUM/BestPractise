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
      this.CurrentAgency = new Agency();
    }

    public Actor(string actorName)
    {
      ActorName = actorName;
    }

    private string _actorName;

    public string ActorName
    {
      get => _actorName;
      set => _actorName = value?.Trim();
    }

    private int _actorAge;

    public int ActorAge
    {
      get { return _actorAge; }
      set { _actorAge = value; }
    }

    public Agency CurrentAgency { get; set; }

    public string ActorDescription { get; set; } = 
      "Regular actor";

    public string JobTitle { get; set; }
    /// <summary>
    /// Will return title
    /// </summary>
    /// <returns></returns>
    public string GetOccupation()
    {
      JobTitle = "Actor";
      return JobTitle;
    }


    /// <summary>
    /// Books actor and not specified date.
    /// </summary>
    /// <returns></returns>
    public string BooKActor()
    {
      return BooKActor(String.Empty);
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
      if (date == String.Empty)
      {
        return $"Actor {ActorName} is booked. {details}";
      }
      return $"Actor {ActorName} is booked on {date}. {details}";
    }

    public string GetAgency()
    {
      //var currentAgency = new Agency();
      return CurrentAgency.Name;
    }

    

  }
}
