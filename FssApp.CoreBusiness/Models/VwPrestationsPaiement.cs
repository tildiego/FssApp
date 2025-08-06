using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwPrestationsPaiement
{
    public string? District { get; set; }

    public string? ZoneDeSante { get; set; }

    public int? FosaId { get; set; }

    public string? Fosa { get; set; }

    public string? IntituleCompteBanquaire { get; set; }

    public string? Libelle { get; set; }

    public decimal? MontantPayeUsd { get; set; }

    public string? Mois { get; set; }

    public string? Annee { get; set; }

    public string MoisAnnee { get; set; } = null!;

    public DateOnly? DatePrestation { get; set; }
}
