using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwZoneDeSanteKisantu
{
    public int ZoneDeSanteId { get; set; }

    public string? VilleTerritoireDistrict { get; set; }

    public string ZoneDeSante { get; set; } = null!;

    public string? Type { get; set; }

    public long? Population { get; set; }
}
