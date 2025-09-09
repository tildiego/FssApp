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
    public class ServiceEFCoreRepository : IServiceEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public ServiceEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task<IEnumerable<Service>> GetAllAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.Services.ToListAsync();
        }

        public async Task<Service> GetServiceByIdAsync(int serviceId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var service = await db.Services.FindAsync(serviceId);
            if (service is not null) return service;

            return new Service();
        }

        public async Task<Service> GetServiceByNameAsync(string name)
        {
            using var db = this.contextFactory.CreateDbContext();
            var service =  await db.Services
                .FirstOrDefaultAsync(x => x.Nom.ToLower().IndexOf(name.ToLower()) >= 0);
            if (service is not null) return service;

            return new Service();
        }
    }
}
