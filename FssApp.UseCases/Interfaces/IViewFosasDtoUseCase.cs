using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IViewFosasDtoUseCase
    {
        Task<IEnumerable<FormationSanitaireDto>> ExecuteAsync();
    }
}