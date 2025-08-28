using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IViewPrestationsUseCase
    {
        Task<IEnumerable<PrestationDto>> ExecuteAsync();
    }
}