using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IMoisEFCoreRepository
    {
        Task<IEnumerable<Moi>> GetAllAsync();
        Task<Moi> GetMoisByIdAsync(int moisId);
        Task<Moi> GetMoisByNameAsync(string name);
    }
}