using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace FssApp.WebApp.MB.Examples.Models;

public class Table
{
    [JsonPropertyName("table")]
    public IReadOnlyCollection<ElementGroup>? ElementGroups { get; set; }
}
