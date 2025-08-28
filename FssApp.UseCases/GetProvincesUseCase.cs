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
    public class GetProvincesUseCase : IGetProvincesUseCase
    {
        private readonly IProvinceEFCoreRepository provinceEFCoreRepository;

        public GetProvincesUseCase(IProvinceEFCoreRepository provinceEFCoreRepository)
        {
            this.provinceEFCoreRepository = provinceEFCoreRepository;
        }

        public async Task<IEnumerable<Province>> ExecuteAsync()
        {
            return await provinceEFCoreRepository.GetAllAsync();
        }
    }
}
