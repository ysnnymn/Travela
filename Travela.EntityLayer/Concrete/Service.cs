using Travela.EntityLayer.Abstract;

namespace Travela.EntityLayer.Concrete;

public class Service : IEntity
{
    public int ServiceId { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }

    public string Icon { get; set; }

    public bool Status { get; set; }
}