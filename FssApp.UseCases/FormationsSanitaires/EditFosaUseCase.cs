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
    public class EditFosaUseCase : IEditFosaUseCase
    {
        private readonly IFosaEFCoreRepository fosaEFCoreRepository;

        public EditFosaUseCase(IFosaEFCoreRepository fosaEFCoreRepository)
        {
            this.fosaEFCoreRepository = fosaEFCoreRepository;
        }

        public async Task ExecuteAsync(FormationSanitaire fosa)
        {
            await fosaEFCoreRepository.UpdateFosaAsync(fosa);
        }
    }
}
