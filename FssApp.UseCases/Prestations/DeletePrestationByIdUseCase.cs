using FssApp.UseCases.Interfaces;
using FssApp.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.UseCases.FormationsSanitaires
{
    public class DeletePrestationByIdUseCase : IDeletePrestationByIdUseCase
    {
        private readonly IPrestationEFCoreRepository prestationEFCoreRepository;

        public DeletePrestationByIdUseCase(IPrestationEFCoreRepository prestationEFCoreRepository)
        {
            this.prestationEFCoreRepository = prestationEFCoreRepository;
        }

        public async Task ExecuteAsync(int prestationId)
        {
            await prestationEFCoreRepository.DeletePrestationByIdAsync(prestationId);
        }
    }
}
