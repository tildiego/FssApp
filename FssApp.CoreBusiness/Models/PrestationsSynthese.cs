using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class PrestationsSynthese
{
    public int Id { get; set; }

    public int FormationSanitaireId { get; set; }

    public int PrestataireId { get; set; }

    public int ServiceId { get; set; }

    public int PrestationCategorieId { get; set; }

    public int EffectifDeclare { get; set; }

    public decimal? CoutUnitaireDeclare { get; set; }

    public decimal? CoutTotalDeclare { get; set; }

    public int? EffectifVerifie { get; set; }

    public decimal? CoutUnitaireVerifie { get; set; }

    public decimal? CoutTotalVerifie { get; set; }

    public int MonnaieId { get; set; }

    public int MoisId { get; set; }

    public int AnneeId { get; set; }

    public DateOnly? DatePrestation { get; set; }

    public virtual Annee Annee { get; set; } = null!;

    public virtual FormationSanitaire FormationSanitaire { get; set; } = null!;

    public virtual Moi Mois { get; set; } = null!;

    public virtual Monnaie Monnaie { get; set; } = null!;

    public virtual Prestataire Prestataire { get; set; } = null!;

    public virtual PrestationCategorie PrestationCategorie { get; set; } = null!;

    public virtual Service Service { get; set; } = null!;
}
