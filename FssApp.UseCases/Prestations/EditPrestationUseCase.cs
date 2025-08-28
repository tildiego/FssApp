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
    public class EditPrestationUseCase : IEditPrestationUseCase
    {
        private readonly IPrestationEFCoreRepository prestationEFCoreRepository;

        public EditPrestationUseCase(IPrestationEFCoreRepository prestationEFCoreRepository)
        {
            this.prestationEFCoreRepository = prestationEFCoreRepository;
        }

        public async Task ExecuteAsync(PrestationsSynthese prestation)
        {
            await prestationEFCoreRepository.UpdatePrestationAsync(prestation);
        }
    }
}
