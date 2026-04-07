using System;
using System.Collections.Generic;

namespace volunteersProject.Models;

public partial class StatusesEvent
{
    public int Id { get; set; }

    public string StatusName { get; set; } = null!;

    public virtual ICollection<Doing> Doings { get; set; } = new List<Doing>();
}
