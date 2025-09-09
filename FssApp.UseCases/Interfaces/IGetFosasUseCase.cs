using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetFosasUseCase
    {
        Task<IEnumerable<FormationSanitaire>> ExecuteAsync();
    }
}