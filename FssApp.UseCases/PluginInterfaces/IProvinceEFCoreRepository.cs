using FssApp.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IProvinceEFCoreRepository
    {
        Task<IEnumerable<Province>> GetAllAsync();
        Task<Province> GetProvinceByIdAsync(int provinceId);
        Task<Province> GetProvinceByNameAsync(string name);
    }
}
