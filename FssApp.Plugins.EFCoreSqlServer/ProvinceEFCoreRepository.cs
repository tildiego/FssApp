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
    public class ProvinceEFCoreRepository : IProvinceEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public ProvinceEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }
        public async Task<IEnumerable<Province>> GetAllAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.Provinces.ToListAsync();
        }

        public async Task<Province> GetProvinceByIdAsync(int provinceId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var province = await db.Provinces.FindAsync(provinceId);
            if (province is not null) return province;

            return new Province();
        }

        public async Task<Province> GetProvinceByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            var province = await db.Provinces.FirstOrDefaultAsync(x => x.Nom.ToLower().IndexOf(name.ToLower()) >= 0);
            if (province is not null) return province;

            return new Province();
        }
    }
}
