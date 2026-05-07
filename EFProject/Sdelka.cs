using System;
using System.Collections.Generic;

namespace EFProject;

public partial class Sdelka
{
    public int IdSdelka { get; set; }

    public string DateSale { get; set; } = null!;

    public double Count { get; set; }

    public int IdProduct { get; set; }

    public int IdClient { get; set; }

    public virtual Client IdClientNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
