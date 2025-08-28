using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetProvincesUseCase
    {
        Task<IEnumerable<Province>> ExecuteAsync();
    }
}