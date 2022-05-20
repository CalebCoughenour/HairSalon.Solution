namespace HairSalon.Models
{
  public class Customer
  {
    public int CustomerId { get; set; }
    public string Name { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }
}