using FssApp.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IDistrictEFCoreRepository
    {
        Task<IEnumerable<District>> GetAllAsync();
        Task<District> GetDistrictByIdAsync(int districtId);
        Task<District> GetDistrictByNameAsync(string name);
    }
}
