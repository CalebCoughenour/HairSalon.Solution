using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Customer
  {

    public int CustomerId { get; set; }
    public string Name { get; set; }

    public string ApptDate { get; set; }
    public virtual Stylist Stylist { get; set; }
  
  }
}