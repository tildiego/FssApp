using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IEditPrestationUseCase
    {
        Task ExecuteAsync(PrestationsSynthese prestation);
    }
}