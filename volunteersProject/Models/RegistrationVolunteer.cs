using System;
using System.Collections.Generic;

namespace volunteersProject.Models;

public partial class RegistrationVolunteer
{
    public int Id { get; set; }

    public int IdEvent { get; set; }

    public int IdUser { get; set; }

    public DateOnly DateRegistration { get; set; }

    public int IdStatusRegistration { get; set; }

    public virtual Event IdEventNavigation { get; set; } = null!;

    public virtual StatusesRegistration IdStatusRegistrationNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
