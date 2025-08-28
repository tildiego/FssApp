using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class Moi
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<PrestationsNeonatologie> PrestationsNeonatologies { get; set; } = new List<PrestationsNeonatologie>();

    public virtual ICollection<PrestationsPaiement> PrestationsPaiements { get; set; } = new List<PrestationsPaiement>();

    public virtual ICollection<PrestationsSyntheseHr> PrestationsSyntheseHrs { get; set; } = new List<PrestationsSyntheseHr>();

    public virtual ICollection<PrestationsSynthese>? PrestationsSyntheses { get; set; } = new List<PrestationsSynthese>();
}
