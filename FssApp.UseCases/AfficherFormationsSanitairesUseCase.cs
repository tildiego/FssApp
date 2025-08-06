using FssApp.CoreBusiness.Models;
using FssApp.UseCases.Interfaces;
using FssApp.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.UseCases
{
    public class AfficherFormationsSanitairesUseCase : IAfficherFormationsSanitairesUseCase
    {
        private readonly IFormationSanitaireEFCoreRepository formationSanitaireRepository;

        public AfficherFormationsSanitairesUseCase(IFormationSanitaireEFCoreRepository formationSanitaireRepository)
        {
            this.formationSanitaireRepository = formationSanitaireRepository;
        }

        public async Task<IEnumerable<FormationSanitaire>> ExecuteAsync(string nom = "")
        {
            // Logique pour récupérer les formations sanitaires
            return await formationSanitaireRepository.GetFormationsSanitairesAsync(nom);
        }
    }
}
