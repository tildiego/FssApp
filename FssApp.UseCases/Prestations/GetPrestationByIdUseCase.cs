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
    public class GetPrestationByIdUseCase : IGetPrestationByIdUseCase
    {
        private readonly IPrestationEFCoreRepository prestationEFCoreRepository;

        public GetPrestationByIdUseCase(IPrestationEFCoreRepository prestationEFCoreRepository)
        {
            this.prestationEFCoreRepository = prestationEFCoreRepository;
        }

        public async Task<PrestationsSynthese> ExcuteAsync(int prestationId)
        {
            return await prestationEFCoreRepository.GetPrestationByIdAsync(prestationId);
        }
    }
}
