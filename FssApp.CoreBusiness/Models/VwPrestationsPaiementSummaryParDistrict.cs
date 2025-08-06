using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwPrestationsPaiementSummaryParDistrict
{
    public string? District { get; set; }

    public string? Mois { get; set; }

    public string? Annee { get; set; }

    public string? Description { get; set; }

    public decimal? MontantsPayeesUsd { get; set; }
}
