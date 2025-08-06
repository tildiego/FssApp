using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IFormationSanitaireEFCoreRepository
    {
        Task<IEnumerable<FormationSanitaire>> GetFormationsSanitairesAsync(string nom);
        Task<IEnumerable<FormationSanitaireDto>> GetFormationsSanitairesDetailsAsync(string nom);
    }
}