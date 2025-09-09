using FssApp.CoreBusiness.DTOs;
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
    public class GetFosasDtoUseCase : IGetFosasDtoUseCase
    {
        private readonly IFosaEFCoreRepository formationSanitaireRepository;

        public GetFosasDtoUseCase(IFosaEFCoreRepository formationSanitaireRepository)
        {
            this.formationSanitaireRepository = formationSanitaireRepository;
        }

        public async Task<IEnumerable<FormationSanitaireDto>> ExecuteAsync()
        {
            return await formationSanitaireRepository.GetAllAsync();
        }
    }
}
