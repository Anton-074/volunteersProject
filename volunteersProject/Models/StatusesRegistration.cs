using System;
using System.Collections.Generic;

namespace volunteersProject.Models;

public partial class StatusesRegistration
{
    public int Id { get; set; }

    public string NameStatuses { get; set; } = null!;

    public virtual ICollection<RegistrationVolunteer> RegistrationVolunteers { get; set; } = new List<RegistrationVolunteer>();
}
