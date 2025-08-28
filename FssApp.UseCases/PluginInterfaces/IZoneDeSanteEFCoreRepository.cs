using FssApp.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IZoneDeSanteEFCoreRepository
    {
        Task<IEnumerable<ZoneDeSante>> GetAllAsync();
        Task<ZoneDeSante> GetZoneDeSanteByIdAsync(int zoneDeSanteId);
        Task<ZoneDeSante> GetZoneDeSanteByNameAsync(string name);
    }
}
