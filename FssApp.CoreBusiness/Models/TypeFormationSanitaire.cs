using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class TypeFormationSanitaire
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string? Code { get; set; }

    public virtual ICollection<FormationSanitaire>? FormationSanitaires { get; set; } = new List<FormationSanitaire>();
}
