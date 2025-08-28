using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class Monnaie
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public string Nom { get; set; } = null!;

    public virtual ICollection<PrestationsSynthese>? PrestationsSyntheses { get; set; } = new List<PrestationsSynthese>();
}
