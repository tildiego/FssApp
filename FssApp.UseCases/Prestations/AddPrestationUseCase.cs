using FssApp.CoreBusiness.Models;
using FssApp.UseCases.Interfaces;
using FssApp.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.UseCases.Prestations
{
    public class AddPrestationUseCase : IAddPrestationUseCase
    {
        private readonly IPrestationEFCoreRepository prestationEFCoreRepository;

        public AddPrestationUseCase(IPrestationEFCoreRepository prestationEFCoreRepository)
        {
            this.prestationEFCoreRepository = prestationEFCoreRepository;
        }

        public async Task ExecuteAsync(PrestationsSynthese prestation)
        {
            await prestationEFCoreRepository.AddPrestationAsync(prestation);
        }
    }
}
