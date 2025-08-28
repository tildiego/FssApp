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
    public class GetDistrictsUseCase : IGetDistrictsUseCase
    {
        private readonly IDistrictEFCoreRepository districtEFCoreRepository;

        public GetDistrictsUseCase(IDistrictEFCoreRepository districtEFCoreRepository)
        {
            this.districtEFCoreRepository = districtEFCoreRepository;
        }

        public async Task<IEnumerable<District>> ExecuteAsync()
        {
            return await districtEFCoreRepository.GetAllAsync();
        }
    }
}
