using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class Intermediaire
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<FormationSanitaire> FormationSanitaires { get; set; } = new List<FormationSanitaire>();
}
