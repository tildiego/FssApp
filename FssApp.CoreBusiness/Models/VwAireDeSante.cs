using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwAireDeSante
{
    public string AireDeSante { get; set; } = null!;

    public string? Province { get; set; }

    public string? District { get; set; }

    public string? ZoneDeSante { get; set; }

    public long? Population { get; set; }
}
