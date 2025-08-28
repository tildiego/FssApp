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
    public class GetMoisUseCase : IGetMoisUseCase
    {
        private readonly IMoisEFCoreRepository moiEFCoreRepository;

        public GetMoisUseCase(IMoisEFCoreRepository moiEFCoreRepository)
        {
            this.moiEFCoreRepository = moiEFCoreRepository;
        }

        public async Task<IEnumerable<Moi>> ExecuteAsync()
        {
            return await moiEFCoreRepository.GetAllAsync();
        }
    }
}
