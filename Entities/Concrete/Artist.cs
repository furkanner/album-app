using Core.Entities;

namespace Entities.Concrete;

public class Artist : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }

    // public virtual ICollection<Album>? Albums { get; set; } 
}