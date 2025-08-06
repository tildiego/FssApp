using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwPrestationsPaiementSummaryHr
{
    public string? Fosa { get; set; }

    public string? Mois { get; set; }

    public string? Annee { get; set; }

    public string? Description { get; set; }

    public decimal? MontantPayeUsd { get; set; }
}
