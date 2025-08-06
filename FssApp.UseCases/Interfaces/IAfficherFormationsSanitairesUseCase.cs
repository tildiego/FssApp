using FssApp.CoreBusiness.Models;

namespace FssApp.UseCases.Interfaces
{
    public interface IAfficherFormationsSanitairesUseCase
    {
        Task<IEnumerable<FormationSanitaire>> ExecuteAsync(string nom = "");
    }
}