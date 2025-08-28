using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;
using FssApp.UseCases.Interfaces;
using FssApp.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.UseCases.FormationsSanitaires
{
    public class ViewFosasUseCase : IViewFosasUseCase
    {
        private readonly IFosaEFCoreRepository formationSanitaireRepository;

        public ViewFosasUseCase(IFosaEFCoreRepository formationSanitaireRepository)
        {
            this.formationSanitaireRepository = formationSanitaireRepository;
        }

        public async Task<IEnumerable<FormationSanitaire>> ExecuteAsync()
        {
            return await formationSanitaireRepository.GetAllFosaAsync();
        }
    }
}
