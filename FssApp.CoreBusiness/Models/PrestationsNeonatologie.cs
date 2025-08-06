using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class PrestationsNeonatologie
{
    public int Id { get; set; }

    public int FormationSanitaireId { get; set; }

    public string NomDuPatient { get; set; } = null!;

    public int PrestationCategorieId { get; set; }

    public int? EffectifDeclare { get; set; }

    public int? NombreDeJourDeclare { get; set; }

    public decimal? CoutUnitaireDeclare { get; set; }

    public decimal? CoutTotalDeclare { get; set; }

    public int? EffectifVerifie { get; set; }

    public int? NombreDeJourVerifie { get; set; }

    public decimal? CoutUnitaireVerifie { get; set; }

    public decimal? CoutTotalVerifie { get; set; }

    public int MoisId { get; set; }

    public int AnneeId { get; set; }

    public DateOnly? DatePrestation { get; set; }

    public virtual Annee Annee { get; set; } = null!;

    public virtual FormationSanitaire FormationSanitaire { get; set; } = null!;

    public virtual Moi Mois { get; set; } = null!;

    public virtual PrestationCategorie PrestationCategorie { get; set; } = null!;
}
