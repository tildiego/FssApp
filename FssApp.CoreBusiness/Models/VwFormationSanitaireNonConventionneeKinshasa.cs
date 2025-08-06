using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwFormationSanitaireNonConventionneeKinshasa
{
    public string? Province { get; set; }

    public string? District { get; set; }

    public string? ZoneDeSanté { get; set; }

    public int FosaId { get; set; }

    public string Fosa { get; set; } = null!;

    public string? FosaNomAlternatif { get; set; }

    public string? Intermediaire { get; set; }

    public string? Adresse { get; set; }
}
