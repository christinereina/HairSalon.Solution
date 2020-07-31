using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Service { get; set; }
    public string Appointment { get; set; }
    public virtual Stylist Stylist { get; set; }

  }
}