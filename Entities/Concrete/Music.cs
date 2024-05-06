using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entities.Concrete;

public class Music : IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public short Duration { get; set; }
    [ForeignKey("Album")] public int AlbumId { get; set; }

    public virtual Album? Album { get; set; }
}