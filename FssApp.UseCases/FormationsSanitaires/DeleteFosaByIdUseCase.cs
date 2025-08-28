using FssApp.UseCases.Interfaces;
using FssApp.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.UseCases.FormationsSanitaires
{
    public class DeleteFosaByIdUseCase : IDeleteFosaByIdUseCase
    {
        private readonly IFosaEFCoreRepository fosaEFCoreRepository;

        public DeleteFosaByIdUseCase(IFosaEFCoreRepository fosaEFCoreRepository)
        {
            this.fosaEFCoreRepository = fosaEFCoreRepository;
        }

        public async Task ExecuteAsync(int fosaId)
        {
            await fosaEFCoreRepository.DeleteFosaByIdAsync(fosaId);
        }
    }
}
