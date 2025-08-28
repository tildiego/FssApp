using FssApp.CoreBusiness.Models;
using FssApp.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.Plugins.EFCoreSqlServer
{
    public class TypeDeFosaEFCoreRepository : ITypeDeFosaEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public TypeDeFosaEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task<IEnumerable<TypeFormationSanitaire>> GetAllAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.TypeFormationSanitaires.ToListAsync();
        }

        public async Task<TypeFormationSanitaire> GetTypeDeFosaByIdAsync(int typeDeFosaId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var typeDeFosa = await db.TypeFormationSanitaires.FindAsync(typeDeFosaId);
            if (typeDeFosa is not null) return typeDeFosa;

            return new TypeFormationSanitaire();
        }

        public async Task<TypeFormationSanitaire> GetTypeDeFosaByCodeAsync(string code)
        {
            using var db = this.contextFactory.CreateDbContext();
            var typeDeFosa = await db.TypeFormationSanitaires
                            .FirstOrDefaultAsync(x => x.Nom.ToLower().IndexOf(code.ToLower()) >= 0);
            if (typeDeFosa is not null) return typeDeFosa;

            return new TypeFormationSanitaire();
        }
    }
}
