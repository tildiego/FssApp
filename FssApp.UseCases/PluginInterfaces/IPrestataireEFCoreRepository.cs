using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IPrestataireEFCoreRepository
    {
        Task<IEnumerable<Prestataire>> GetAllAsync();
        Task<Prestataire> GetPrestataireByIdAsync(int prestataireId);
        Task<Prestataire> GetPrestataireByNameAsync(string name);
    }
}