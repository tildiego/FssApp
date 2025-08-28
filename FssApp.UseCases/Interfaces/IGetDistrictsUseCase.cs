using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetDistrictsUseCase
    {
        Task<IEnumerable<District>> ExecuteAsync();
    }
}