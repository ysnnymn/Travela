using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Travela.EntityLayer.Abstract;

namespace Travela.EntityLayer.Concrete;

public class About:IEntity
{
    public int AboutId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}