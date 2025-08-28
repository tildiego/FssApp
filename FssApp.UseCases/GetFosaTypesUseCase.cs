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
    public class GetFosaTypesUseCase : IGetFosaTypesUseCase
    {
        private readonly ITypeDeFosaEFCoreRepository typeDeFosaEFCoreRepository;

        public GetFosaTypesUseCase(ITypeDeFosaEFCoreRepository typeDeFosaEFCoreRepository)
        {
            this.typeDeFosaEFCoreRepository = typeDeFosaEFCoreRepository;
        }

        public async Task<IEnumerable<TypeFormationSanitaire>> ExecuteAsync()
        {
            return await typeDeFosaEFCoreRepository.GetAllAsync();
        }
    }
}
