using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetFosaTypesUseCase
    {
        Task<IEnumerable<TypeFormationSanitaire>> ExecuteAsync();
    }
}