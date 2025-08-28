using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IPrestationCategorieEFCoreRepository
    {
        Task<IEnumerable<PrestationCategorie>> GetAllAsync();
        Task<PrestationCategorie> GetPrestationCategorieByIdAsync(int prestationCategorieId);
        Task<PrestationCategorie> GetPrestationCategorieByNameAsync(string name);
    }
}