using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetFosaByIdUseCase
    {
        Task<FormationSanitaire> ExcuteAsync(int fosaId);
    }
}