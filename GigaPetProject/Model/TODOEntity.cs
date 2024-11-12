using System;
using System.ComponentModel.DataAnnotations;

namespace GigaPetProject.Model;

public sealed class TODOEntity : DatedEntity
{
    public bool Done { get; set; }
    [Required] [StringLength(64)] public string Title { get; set; }
    [StringLength(256)] public string Description { get; set; }
    public DateTime DueDate { get; set; }
    [Range(1, 5)] public int Priority { get; set; }

    public TODOEntity() : base() { }
}