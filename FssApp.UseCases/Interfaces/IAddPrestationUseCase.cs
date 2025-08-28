using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IAddPrestationUseCase
    {
        Task ExecuteAsync(PrestationsSynthese prestation);
    }
}