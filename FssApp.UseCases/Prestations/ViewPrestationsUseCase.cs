using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;
using FssApp.UseCases.Interfaces;
using FssApp.UseCases.PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.UseCases.Prestations
{
    public class ViewPrestationsUseCase : IViewPrestationsUseCase
    {
        private readonly IPrestationEFCoreRepository prestationRepository;

        public ViewPrestationsUseCase(IPrestationEFCoreRepository prestationRepository)
        {
            this.prestationRepository = prestationRepository;
        }

        public async Task<IEnumerable<PrestationDto>> ExecuteAsync()
        {
            return await prestationRepository.GetAllAsync();
        }
    }
}
