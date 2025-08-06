using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwPrestationsPaiementSumMontantPayeUsd
{
    public int FormationSanitaireId { get; set; }

    public decimal? MontantPayeUsd { get; set; }
}
