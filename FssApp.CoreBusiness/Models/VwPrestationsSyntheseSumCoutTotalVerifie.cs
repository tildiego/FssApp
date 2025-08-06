using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwPrestationsSyntheseSumCoutTotalVerifie
{
    public int FormationSanitaireId { get; set; }

    public decimal? CoutTotalVerifie { get; set; }

    public int MoisId { get; set; }

    public int AnneeId { get; set; }

    public DateOnly? DatePrestation { get; set; }
}
