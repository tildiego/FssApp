using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IMonnaieEFCoreRepository
    {
        Task<IEnumerable<Monnaie>> GetAllAsync();
        Task<Monnaie> GetMonnaieByIdAsync(int monnaieId);
        Task<Monnaie> GetMonnaieByNameAsync(string name);
    }
}