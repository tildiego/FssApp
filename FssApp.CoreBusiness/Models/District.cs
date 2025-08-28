using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class District
{
    public int Id { get; set; }

    public string Nom { get; set; } = null!;

    public string? TypeEntite { get; set; }

    public string? FssCode { get; set; }

    public int ProvinceId { get; set; }

    public virtual Province Province { get; set; } = null!;

    public virtual ICollection<ZoneDeSante>? ZoneDeSantes { get; set; } = new List<ZoneDeSante>();
}
