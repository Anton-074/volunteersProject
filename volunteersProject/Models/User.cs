using System;
using System.Collections.Generic;

namespace volunteersProject.Models;

public partial class User
{
    public int Id { get; set; }

    public string FullName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdRole { get; set; }

    public virtual ICollection<Doing> Doings { get; set; } = new List<Doing>();

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<RegistrationVolunteer> RegistrationVolunteers { get; set; } = new List<RegistrationVolunteer>();
}
