using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetAnneesUseCase
    {
        Task<IEnumerable<Annee>> ExecuteAsync();
    }
}