using System;
using System.Collections.Generic;

namespace EFProject;

public partial class Client
{

    public int IdClient { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public string SurName { get; set; } = null!;

    public string? Firma { get; set; }

    public string CityClient { get; set; } = null!;

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Sdelka> Sdelkas { get; set; } = new List<Sdelka>();
}
