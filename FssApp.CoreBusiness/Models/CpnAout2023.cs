using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class CpnAout2023
{
    public int Id { get; set; }

    public int FormationSanitaireId { get; set; }

    public int? Cpn1 { get; set; }

    public int? Cpn2 { get; set; }

    public int? Cpn3 { get; set; }

    public int? Cpn4 { get; set; }

    public virtual FormationSanitaire FormationSanitaire { get; set; } = null!;
}
