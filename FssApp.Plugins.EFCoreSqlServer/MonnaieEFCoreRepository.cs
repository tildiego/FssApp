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
    public class MonnaieEFCoreRepository : IMonnaieEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public MonnaieEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Monnaie>> GetAllAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.Monnaies.ToListAsync();
        }

        public async Task<Monnaie> GetMonnaieByIdAsync(int monnaieId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var monnaie = await db.Monnaies.FindAsync(monnaieId);
            if (monnaie is not null) return monnaie;

            return new Monnaie();
        }

        public async Task<Monnaie> GetMonnaieByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            var monnaie =  await db.Monnaies
                .FirstOrDefaultAsync(x => x.Nom.ToLower().IndexOf(name.ToLower()) >= 0);
            if (monnaie is not null) return monnaie;

            return new Monnaie();
        }
    }
}
