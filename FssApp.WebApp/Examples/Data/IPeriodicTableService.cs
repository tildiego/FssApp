using FssApp.WebApp.MB.Examples.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FssApp.WebApp.Examples.Data;

public interface IPeriodicTableService
{
    Task<IEnumerable<Element>> GetElements();

    Task<IEnumerable<Element>> GetElements(string search);
}
