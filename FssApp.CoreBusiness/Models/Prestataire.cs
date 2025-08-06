using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class Prestataire
{
    public int Id { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<PrestationsSyntheseHr> PrestationsSyntheseHrs { get; set; } = new List<PrestationsSyntheseHr>();

    public virtual ICollection<PrestationsSynthese> PrestationsSyntheses { get; set; } = new List<PrestationsSynthese>();
}
