using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwFormationSanitaireToBeDeleted
{
    public string? Province { get; set; }

    public string? Territoire { get; set; }

    public string? ZoneDeSante { get; set; }

    public string? TypeFosa { get; set; }

    public int FosaId { get; set; }

    public string Fosa { get; set; } = null!;

    public int? ZoneDeSanteId { get; set; }

    public string? IntituleCompteBanquaire { get; set; }

    public string? Adresse { get; set; }

    public string? CompteBanquaireCdf { get; set; }

    public string? Telephone { get; set; }

    public string? ResponsableTelephone { get; set; }

    public string? Statut { get; set; }

    public string FosaConventionnee { get; set; } = null!;
}
