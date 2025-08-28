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
    public class PrestataireEFCoreRepository : IPrestataireEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public PrestataireEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Prestataire>> GetAllAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.Prestataires.ToListAsync();
        }

        public async Task<Prestataire> GetPrestataireByIdAsync(int prestataireId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var prestataire = await db.Prestataires.FindAsync(prestataireId);
            if (prestataire is not null) return prestataire;

            return new Prestataire();
        }

        public async Task<Prestataire> GetPrestataireByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            var prestataire =  await db.Prestataires.FirstOrDefaultAsync(x => x.Type.ToLower().IndexOf(name.ToLower()) >= 0);
            if (prestataire is not null) return prestataire;

            return new Prestataire();
        }
    }
}
