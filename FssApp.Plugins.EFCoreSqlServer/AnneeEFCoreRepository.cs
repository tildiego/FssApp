using FssApp.CoreBusiness.DTOs;
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
    public class AnneeEFCoreRepository : IAnneeEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public AnneeEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Annee>> GetAllAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.Annees.ToListAsync();
        }

        public async Task<Annee> GetAnneeByIdAsync(int anneeId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var annee = await db.Annees.FindAsync(anneeId);
            if (annee is not null) return annee;

            return new Annee();
        }

        public async Task<Annee> GetAnneeByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            var annee =  await db.Annees.FirstOrDefaultAsync(x => x.Nom.ToLower().IndexOf(name.ToLower()) >= 0);
            if (annee is not null) return annee;

            return new Annee();
        }
    }
}
