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
    public class PrestationCategorieEFCoreRepository : IPrestationCategorieEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public PrestationCategorieEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task<IEnumerable<PrestationCategorie>> GetAllAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.PrestationCategories.ToListAsync();
        }

        public async Task<PrestationCategorie> GetPrestationCategorieByIdAsync(int prestationCategorieId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var prestationCategorie = await db.PrestationCategories.FindAsync(prestationCategorieId);
            if (prestationCategorie is not null) return prestationCategorie;

            return new PrestationCategorie();
        }

        public async Task<PrestationCategorie> GetPrestationCategorieByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            var prestationCategorie =  await db.PrestationCategories.FirstOrDefaultAsync(x => x.Nom.ToLower().IndexOf(name.ToLower()) >= 0);
            if (prestationCategorie is not null) return prestationCategorie;

            return new PrestationCategorie();
        }
    }
}
