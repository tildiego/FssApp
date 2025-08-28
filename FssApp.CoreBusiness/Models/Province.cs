using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class Province
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string? Code { get; set; }

    public string? Capitale { get; set; }

    public long? Superficie { get; set; }

    public long? Population { get; set; }

    public string? AncienNom { get; set; }

    public string? FuseauHoraire { get; set; }

    public string? CodePostal { get; set; }

    public virtual ICollection<District>? Districts { get; set; } = new List<District>();
}
