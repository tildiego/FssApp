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
    public class GetFosaByIdUseCase : IGetFosaByIdUseCase
    {
        private readonly IFosaEFCoreRepository fosaEFCoreRepository;

        public GetFosaByIdUseCase(IFosaEFCoreRepository fosaEFCoreRepository)
        {
            this.fosaEFCoreRepository = fosaEFCoreRepository;
        }

        public async Task<FormationSanitaire> ExcuteAsync(int fosaId)
        {
            return await fosaEFCoreRepository.GetFosaByIdAsync(fosaId);
        }
    }
}
