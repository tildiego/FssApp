using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetPrestationsUseCase
    {
        Task<IEnumerable<PrestationDto>> ExecuteAsync();
    }
}