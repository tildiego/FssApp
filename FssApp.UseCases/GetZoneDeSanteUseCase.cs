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
    public class GetZoneDeSanteUseCase : IGetZoneDeSanteUseCase
    {
        private readonly IZoneDeSanteEFCoreRepository zoneDeSanteEFCoreRepository;

        public GetZoneDeSanteUseCase(IZoneDeSanteEFCoreRepository zoneDeSanteEFCoreRepository)
        {
            this.zoneDeSanteEFCoreRepository = zoneDeSanteEFCoreRepository;
        }

        public async Task<IEnumerable<ZoneDeSante>> ExecuteAsync()
        {
            return await zoneDeSanteEFCoreRepository.GetAllAsync();
        }
    }
}
