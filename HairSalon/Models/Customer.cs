namespace HairSalon.Models
{
  public class Customer
  {

    public Customer()
    {
      this.Stylists = new HashSet<Stylist>();
    }
    public int CustomerId { get; set; }
    public string Name { get; set; }

    public string ApptDate { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
    public virtual ICollection<Stylist> Stylists { get; set; }
  }
}