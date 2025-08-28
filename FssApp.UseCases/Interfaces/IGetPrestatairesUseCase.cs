using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetPrestatairesUseCase
    {
        Task<IEnumerable<Prestataire>> ExecuteAsync();
    }
}