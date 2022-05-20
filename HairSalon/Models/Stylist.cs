using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Customers = new HashSet<Customer>();
    }

    public string Name { get; set; }
    public string Specialty { get; set; }
    public int StylistId { get; set; }

    public int CustomerId { get; set; }
    public virtual ICollection<Customer> Customers { get; set; }
    public virtual Customer Customer { get; set; }
  }
}