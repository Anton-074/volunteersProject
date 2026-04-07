using System;
using System.Collections.Generic;

namespace volunteersProject.Models;

public partial class Category
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<Doing> Doings { get; set; } = new List<Doing>();
}
