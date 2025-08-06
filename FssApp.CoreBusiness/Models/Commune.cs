using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class Commune
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public string? CodePostal { get; set; }

    public int? ProvinceId { get; set; }
}
