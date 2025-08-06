using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class PrestationCategorie
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public virtual ICollection<PrestationsNeonatologie> PrestationsNeonatologies { get; set; } = new List<PrestationsNeonatologie>();

    public virtual ICollection<PrestationsSyntheseHr> PrestationsSyntheseHrs { get; set; } = new List<PrestationsSyntheseHr>();

    public virtual ICollection<PrestationsSynthese> PrestationsSyntheses { get; set; } = new List<PrestationsSynthese>();
}
