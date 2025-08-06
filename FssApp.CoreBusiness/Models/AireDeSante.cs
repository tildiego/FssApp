using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class AireDeSante
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public long? Population { get; set; }

    public int ZoneDeSanteId { get; set; }
}
