using System;
using System.Collections.Generic;

namespace volunteersProject.Models;

public partial class Doing
{
    public int Id { get; set; }

    public string DoingName { get; set; } = null!;

    public int IdCategory { get; set; }

    public DateOnly Date { get; set; }

    public int IdPlace { get; set; }

    public int CountVolunteer { get; set; }

    public int IdUser { get; set; }

    public int IdStatusEvent { get; set; }

    public virtual Category IdCategoryNavigation { get; set; } = null!;

    public virtual Place IdPlaceNavigation { get; set; } = null!;

    public virtual StatusesEvent IdStatusEventNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
