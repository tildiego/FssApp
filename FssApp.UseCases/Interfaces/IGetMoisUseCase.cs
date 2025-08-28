using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetMoisUseCase
    {
        Task<IEnumerable<Moi>> ExecuteAsync();
    }
}