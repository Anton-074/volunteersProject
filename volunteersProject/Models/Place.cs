using System;
using System.Collections.Generic;

namespace volunteersProject.Models;

public partial class Place
{
    public int Id { get; set; }

    public string PlaceName { get; set; } = null!;

    public virtual ICollection<Doing> Doings { get; set; } = new List<Doing>();
}
