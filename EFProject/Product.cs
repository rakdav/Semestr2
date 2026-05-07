using System;
using System.Collections.Generic;

namespace EFProject;

public partial class Product
{
    public int IdProduct { get; set; }

    public string NameProduct { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string? Sort { get; set; }

    public int Remainder { get; set; }

    public string CityProduct { get; set; } = null!;

    public virtual ICollection<Sdelka> Sdelkas { get; set; } = new List<Sdelka>();

    public override string? ToString()
    {
        return NameProduct+" "+Type+" "+Sort+" "+Remainder+" "+CityProduct;
    }
}
