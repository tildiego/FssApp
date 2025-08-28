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
    public class ZoneDeSanteEFCoreRepository : IZoneDeSanteEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public ZoneDeSanteEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task<IEnumerable<ZoneDeSante>> GetAllAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.ZoneDeSantes.ToListAsync();
        }

        public async Task<ZoneDeSante> GetZoneDeSanteByIdAsync(int zoneDeSanteId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var zoneDeSante = await db.ZoneDeSantes.FindAsync(zoneDeSanteId);
            if (zoneDeSante is not null) return zoneDeSante;

            return new ZoneDeSante();
        }

        public async Task<ZoneDeSante> GetZoneDeSanteByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            var zoneDeSante =  await db.ZoneDeSantes.FirstOrDefaultAsync(x => x.Nom.ToLower().IndexOf(name.ToLower()) >= 0);
            if (zoneDeSante is not null) return zoneDeSante;

            return new ZoneDeSante();
        }
    }
}
