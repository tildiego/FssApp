using FssApp.CoreBusiness.Models;
using FssApp.UseCases.PluginInterfaces;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetServiceUseCase
    {
        Task<IEnumerable<Service>> ExecuteAsync();
    }
}