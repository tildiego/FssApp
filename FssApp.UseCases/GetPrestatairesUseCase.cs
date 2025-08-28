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
    public class GetPrestatairesUseCase : IGetPrestatairesUseCase
    {
        private readonly IPrestataireEFCoreRepository prestataireEFCoreRepository;

        public GetPrestatairesUseCase(IPrestataireEFCoreRepository prestataireEFCoreRepository)
        {
            this.prestataireEFCoreRepository = prestataireEFCoreRepository;
        }

        public async Task<IEnumerable<Prestataire>> ExecuteAsync()
        {
            return await prestataireEFCoreRepository.GetAllAsync();
        }
    }
}
