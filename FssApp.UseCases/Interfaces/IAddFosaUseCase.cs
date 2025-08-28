using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IAddFosaUseCase
    {
        Task ExecuteAsync(FormationSanitaire formationSanitaire);
    }
}