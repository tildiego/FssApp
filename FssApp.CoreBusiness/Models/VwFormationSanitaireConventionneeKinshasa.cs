using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwFormationSanitaireConventionneeKinshasa
{
    public string? District { get; set; }

    public string? ZoneDeSanté { get; set; }

    public int FosaId { get; set; }

    public string Fosa { get; set; } = null!;

    public string? TypeFosa { get; set; }

    public string? Adresse { get; set; }

    public string? Téléphone { get; set; }

    public string NomDuResponsable { get; set; } = null!;

    public string? NumTéléphoneDuResponsable { get; set; }

    public string? Statut { get; set; }
}
