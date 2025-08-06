using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class ZoneDeSante
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public long? Population { get; set; }

    public string? FssCode { get; set; }

    public int DistrictId { get; set; }

    public virtual District District { get; set; } = null!;

    public virtual ICollection<FormationSanitaire> FormationSanitaires { get; set; } = new List<FormationSanitaire>();
}
