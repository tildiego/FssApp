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
    public class AddFosaUseCase : IAddFosaUseCase
    {
        private readonly IFosaEFCoreRepository fosaEFCoreRepository;

        public AddFosaUseCase(IFosaEFCoreRepository fosaEFCoreRepository)
        {
            this.fosaEFCoreRepository = fosaEFCoreRepository;
        }

        public async Task ExecuteAsync(FormationSanitaire formationSanitaire)
        {
            await fosaEFCoreRepository.AddFosaAsync(formationSanitaire);
        }
    }
}
