using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetPrestationByIdUseCase
    {
        Task<PrestationsSynthese> ExcuteAsync(int prestationId);
    }
}