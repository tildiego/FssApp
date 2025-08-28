using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetZoneDeSanteUseCase
    {
        Task<IEnumerable<ZoneDeSante>> ExecuteAsync();
    }
}