using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IGetFosasDtoUseCase
    {
        Task<IEnumerable<FormationSanitaireDto>> ExecuteAsync();
    }
}