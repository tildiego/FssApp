using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwPrestationsNeonatologie
{
    public string? District { get; set; }

    public string? ZoneDeSante { get; set; }

    public int? FosaId { get; set; }

    public string? Fosa { get; set; }

    public string? TypeFosa { get; set; }

    public string? PrestationCategorie { get; set; }

    public int? EffectifDeclare { get; set; }

    public int? NombreDeJourDeclare { get; set; }

    public decimal? CoutUnitaireDeclare { get; set; }

    public decimal? CoutTotalDeclare { get; set; }

    public int? EffectifVerifie { get; set; }

    public int? NombreDeJourVerifie { get; set; }

    public decimal? CoutUnitaireVerifie { get; set; }

    public decimal? CoutTotalVerifie { get; set; }

    public string? Mois { get; set; }

    public string? Annee { get; set; }
}
