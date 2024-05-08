using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concrete;

public class Album : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Time { get; set; }
    [ForeignKey("Artist")] public int ArtistId { get; set; }
    public virtual Artist? Artist { get; set; }
}