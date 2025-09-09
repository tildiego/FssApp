using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IServiceEFCoreRepository
    {
        Task<IEnumerable<Service>> GetAllAsync();
        Task<Service> GetServiceByIdAsync(int serviceId);
        Task<Service> GetServiceByNameAsync(string name);
    }
}