using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetPrestationCategoriesUseCase
    {
        Task<IEnumerable<PrestationCategorie>> ExecuteAsync();
    }
}