using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IAnneeEFCoreRepository
    {
        Task<IEnumerable<Annee>> GetAllAsync();
        Task<Annee> GetAnneeByIdAsync(int anneeId);
        Task<Annee> GetAnneeByNameAsync(string name);
    }
}