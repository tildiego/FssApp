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
    public class GetPrestationCategoriesUseCase : IGetPrestationCategoriesUseCase
    {
        private readonly IPrestationCategorieEFCoreRepository PrestationCategorieEFCoreRepository;

        public GetPrestationCategoriesUseCase(IPrestationCategorieEFCoreRepository PrestationCategorieEFCoreRepository)
        {
            this.PrestationCategorieEFCoreRepository = PrestationCategorieEFCoreRepository;
        }

        public async Task<IEnumerable<PrestationCategorie>> ExecuteAsync()
        {
            return await PrestationCategorieEFCoreRepository.GetAllAsync();
        }
    }
}
