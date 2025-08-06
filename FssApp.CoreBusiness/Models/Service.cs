using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class Service
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public virtual ICollection<PrestationsSynthese> PrestationsSyntheses { get; set; } = new List<PrestationsSynthese>();
}
