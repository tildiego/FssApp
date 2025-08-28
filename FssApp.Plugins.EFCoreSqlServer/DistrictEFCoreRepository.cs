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
    public class DistrictEFCoreRepository : IDistrictEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public DistrictEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }
        public async Task<IEnumerable<District>> GetAllAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.Districts.ToListAsync();
        }

        public async Task<District> GetDistrictByIdAsync(int districtId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var district = await db.Districts.FindAsync(districtId);
            if (district is not null) return district;

            return new District();
        }

        public async Task<District> GetDistrictByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            var dictrict = await db.Districts.FirstOrDefaultAsync(x => x.Nom.ToLower().IndexOf(name.ToLower()) >= 0);
            if (dictrict is not null) return dictrict;

            return new District();
        }
    }
}
