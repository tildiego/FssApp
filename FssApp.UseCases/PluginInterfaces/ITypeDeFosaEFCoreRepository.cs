using FssApp.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface ITypeDeFosaEFCoreRepository
    {
        Task<IEnumerable<TypeFormationSanitaire>> GetAllAsync();
        Task<TypeFormationSanitaire> GetTypeDeFosaByIdAsync(int typeDeFosaId);
        Task<TypeFormationSanitaire> GetTypeDeFosaByCodeAsync(string code);
    }
}
