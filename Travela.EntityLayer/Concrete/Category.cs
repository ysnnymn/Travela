using Travela.EntityLayer.Abstract;

namespace Travela.EntityLayer.Concrete;

public class Category:IEntity
{
    public int  CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string ImageUrl { get; set; }
    
    
}