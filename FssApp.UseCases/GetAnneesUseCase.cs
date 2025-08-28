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
    public class GetAnneesUseCase : IGetAnneesUseCase
    {
        private readonly IAnneeEFCoreRepository anneeEFCoreRepository;

        public GetAnneesUseCase(IAnneeEFCoreRepository anneeEFCoreRepository)
        {
            this.anneeEFCoreRepository = anneeEFCoreRepository;
        }

        public async Task<IEnumerable<Annee>> ExecuteAsync()
        {
            return await anneeEFCoreRepository.GetAllAsync();
        }
    }
}
