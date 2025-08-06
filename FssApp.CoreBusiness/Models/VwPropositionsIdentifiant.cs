using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class VwPropositionsIdentifiant
{
    public string? Province { get; set; }

    public string? Pcode { get; set; }

    public string? District { get; set; }

    public string? Dcode { get; set; }

    public string? ZoneDeSante { get; set; }

    public string? ZsCode1 { get; set; }

    public string? ZsCode2 { get; set; }

    public string? ZsCode3 { get; set; }

    public string FosaCode1 { get; set; } = null!;

    public string FosaCode2 { get; set; } = null!;

    public string FosaCode3 { get; set; } = null!;

    public string FosaCode4 { get; set; } = null!;

    public string FosaCode5 { get; set; } = null!;

    public string Fosa { get; set; } = null!;

    public string? FosaNomAlternatif { get; set; }

    public string? TypeDeFosa { get; set; }
}
