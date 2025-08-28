using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetMonnaiesUseCase
    {
        Task<IEnumerable<Monnaie>> ExecuteAsync();
    }
}