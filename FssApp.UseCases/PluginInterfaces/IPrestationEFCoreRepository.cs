using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.PluginInterfaces
{
    public interface IPrestationEFCoreRepository
    {
        Task<IEnumerable<PrestationDto>> GetAllAsync();
        Task<IEnumerable<PrestationsSynthese>> GetAllPrestationsAsync();
        Task AddPrestationAsync(PrestationsSynthese prestation);
        Task DeletePrestationByIdAsync(int prestationId);
        Task<PrestationsSynthese> GetPrestationByIdAsync(int prestationId);
        Task UpdatePrestationAsync(PrestationsSynthese prestation);
    }
}