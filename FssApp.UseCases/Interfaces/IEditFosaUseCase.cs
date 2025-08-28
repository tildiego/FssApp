using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IEditFosaUseCase
    {
        Task ExecuteAsync(FormationSanitaire fosa);
    }
}