using System.Collections.Generic;

namespace FssApp.WebApp.MB.Examples.Models;

public class ElementGroup
{
    public string? Wiki { get; set; }

    public IReadOnlyCollection<Element>? Elements { get; set; }
}
