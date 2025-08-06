using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwPrestationsSyntheseSummaryKasaiOriental
{
    public string? Province { get; set; }

    public string? Mois { get; set; }

    public string? Annee { get; set; }

    public decimal? CoutTotalDeclare { get; set; }

    public decimal? CoutTotalVerifie { get; set; }
}
