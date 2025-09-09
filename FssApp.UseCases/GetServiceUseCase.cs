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
    public class GetServiceUseCase : IGetServiceUseCase
    {
        private readonly IServiceEFCoreRepository serviceEFCoreRepository;

        public GetServiceUseCase(IServiceEFCoreRepository serviceEFCoreRepository)
        {
            this.serviceEFCoreRepository = serviceEFCoreRepository;
        }

        public async Task<IEnumerable<Service>> ExecuteAsync()
        {
            return await serviceEFCoreRepository.GetAllAsync();
        }
    }
}
