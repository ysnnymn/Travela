using Travela.EntityLayer.Abstract;

namespace Travela.EntityLayer.Concrete;

public class Destination:IEntity    
{
    public int DestinationId { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string ImageUrl { get; set; }
    public string CountDay { get; set; }
    public string SubTitle { get; set; }
    public string Descripiton { get; set; }
    public decimal Price { get; set; }
    public DateTime Date { get; set; }
    
}