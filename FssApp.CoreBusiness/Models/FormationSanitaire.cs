using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class FormationSanitaire
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string? IntituleCompteBanquaire { get; set; }

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

    public string? AireDeSante { get; set; }

    public int TypeFormationSanitaireId { get; set; }

    public string? NomBanque { get; set; }

    public string? CompteBanquaireUs { get; set; }

    public string? CompteBanquaireCdf { get; set; }

    public int? IntermediaireId { get; set; }

    public bool FosaConventionnee { get; set; }

    public bool ServiceNeonatologie { get; set; }

    public virtual ICollection<CpnAout2023> CpnAout2023s { get; set; } = new List<CpnAout2023>();

    public virtual Intermediaire? Intermediaire { get; set; }

    public virtual ICollection<PrestationsNeonatologie> PrestationsNeonatologies { get; set; } = new List<PrestationsNeonatologie>();

    public virtual ICollection<PrestationsPaiement> PrestationsPaiements { get; set; } = new List<PrestationsPaiement>();

    public virtual ICollection<PrestationsSyntheseHr> PrestationsSyntheseHrs { get; set; } = new List<PrestationsSyntheseHr>();

    public virtual ICollection<PrestationsSynthese> PrestationsSyntheses { get; set; } = new List<PrestationsSynthese>();

    public virtual TypeFormationSanitaire TypeFormationSanitaire { get; set; } = null!;

    public virtual ZoneDeSante ZoneDeSante { get; set; } = null!;
}
