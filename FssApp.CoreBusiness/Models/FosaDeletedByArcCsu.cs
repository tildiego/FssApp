using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class FosaDeletedByArcCsu
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string? Description { get; set; }

    public bool? ToBeDeleted { get; set; }

    public string? Adresse { get; set; }

    public string? Telephone { get; set; }

    public string? ResponsableNom { get; set; }

    public string? ResponsablePostNom { get; set; }

    public string? ResponsablePrenom { get; set; }

    public string? ResponsableTelephone { get; set; }

    public string? ResponsableEmail { get; set; }

    public string? Statut { get; set; }

    public int ZoneDeSanteId { get; set; }

    public int TypeFormationSanitaireId { get; set; }

    public string? NomBanque { get; set; }

    public string? CompteBanquaireUs { get; set; }

    public string? CompteBanquaireCdf { get; set; }
}
