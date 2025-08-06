using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwFormationSanitaireKinshasa
{
    public string? Province { get; set; }

    public string? District { get; set; }

    public string? ZoneDeSante { get; set; }

    public string? TypeFosa { get; set; }

    public int FosaId { get; set; }

    public string Fosa { get; set; } = null!;

    public string? IntituleCompteBanquaire { get; set; }

    public string? Adresse { get; set; }

    public string? Telephone { get; set; }

    public string? ResponsableTelephone { get; set; }

    public bool FosaConventionnee { get; set; }

    public bool ServiceNeonatologie { get; set; }
}
