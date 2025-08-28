using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IFosaEFCoreRepository
    {
        Task AddFosaAsync(FormationSanitaire formationSanitaire);
        Task DeleteFosaByIdAsync(int fosaId);
        Task<IEnumerable<FormationSanitaireDto>> GetAllAsync();
        Task<IEnumerable<FormationSanitaire>> GetAllFosaAsync();
        Task<FormationSanitaire> GetFosaByIdAsync(int fosaId);
        Task UpdateFosaAsync(FormationSanitaire fosa);
    }
}