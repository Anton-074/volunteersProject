using System;
using System.Collections.Generic;

namespace volunteersProject.Models;

public partial class Event
{
    public int Id { get; set; }

    public string EventName { get; set; } = null!;

    public virtual ICollection<RegistrationVolunteer> RegistrationVolunteers { get; set; } = new List<RegistrationVolunteer>();
}
