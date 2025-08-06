using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class PrestationsPaiement
{
    public int Id { get; set; }

    public int FormationSanitaireId { get; set; }

    public string? Description { get; set; }

    public decimal? MontantPayeUsd { get; set; }

    public int MoisId { get; set; }

    public int AnneeId { get; set; }

    public DateOnly? DatePrestation { get; set; }

    public virtual Annee Annee { get; set; } = null!;

    public virtual FormationSanitaire FormationSanitaire { get; set; } = null!;

    public virtual Moi Mois { get; set; } = null!;
}
