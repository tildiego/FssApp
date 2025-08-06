using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwPrestationsPopulationCible
{
    public string? NomZoneDeSante { get; set; }

    public long? PopulationZoneDeSante { get; set; }

    public int FosaId { get; set; }

    public int TypeFosaId { get; set; }

    public string Nom { get; set; } = null!;
}
