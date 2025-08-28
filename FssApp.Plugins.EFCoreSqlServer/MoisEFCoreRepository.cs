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
    public class MoisEFCoreRepository : IMoisEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public MoisEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Moi>> GetAllAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.Mois.ToListAsync();
        }

        public async Task<Moi> GetMoisByIdAsync(int moisId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var mois = await db.Mois.FindAsync(moisId);
            if (mois is not null) return mois;

            return new Moi();
        }

        public async Task<Moi> GetMoisByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            var mois =  await db.Mois
                .FirstOrDefaultAsync(x => x.Nom.ToLower().IndexOf(name.ToLower()) >= 0);
            if (mois is not null) return mois;

            return new Moi();
        }
    }
}
