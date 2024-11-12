using System;
using System.ComponentModel.DataAnnotations;

namespace GigaPetProject.Model;

public abstract class Entity
{
    [Key] public long ID { get; set; }
}

public abstract class DatedEntity : Entity
{
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public DatedEntity() : base()
    {
        CreatedAt = DateTime.Now;
        UpdatedAt = DateTime.Now;
    }
}
