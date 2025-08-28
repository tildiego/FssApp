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
    public class GetMonnaiesUseCase : IGetMonnaiesUseCase
    {
        private readonly IMonnaieEFCoreRepository monnaieEFCoreRepository;

        public GetMonnaiesUseCase(IMonnaieEFCoreRepository monnaieEFCoreRepository)
        {
            this.monnaieEFCoreRepository = monnaieEFCoreRepository;
        }

        public async Task<IEnumerable<Monnaie>> ExecuteAsync()
        {
            return await monnaieEFCoreRepository.GetAllAsync();
        }
    }
}
