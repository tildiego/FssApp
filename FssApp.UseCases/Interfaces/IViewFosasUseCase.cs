using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IViewFosasUseCase
    {
        Task<IEnumerable<FormationSanitaire>> ExecuteAsync();
    }
}