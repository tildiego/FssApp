using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;
using FssApp.UseCases.PluginInterfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.Plugins.EFCoreSqlServer
{
    public class FormationSanitaireEFCoreRepository : IFormationSanitaireEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public FormationSanitaireEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task<IEnumerable<FormationSanitaire>> GetFormationsSanitairesAsync(string nom)
        {
            using var db = this.contextFactory.CreateDbContext();
            return await db.FormationSanitaires.Where(x => x.Nom.ToLower().IndexOf(nom.ToLower()) >= 0)
                                               .OrderBy(x => x.Nom)
                                               .ToListAsync();
        }

        public async Task<IEnumerable<FormationSanitaireDto>> GetFormationsSanitairesDetailsAsync(string nom)
        {
            //using var db = this.contextFactory.CreateDbContext();
            //var query = from formationSanitaire in db.FormationSanitaires
            //            join zoneDeSante in db.ZoneDeSantes on formationSanitaire.ZoneDeSanteId equals zoneDeSante.Id
            //            where formationSanitaire.Nom.ToLower().IndexOf(nom.ToLower()) >= 0
            //            select new {
            //                NomZoneDeSante = zoneDeSante.Nom,
            //                NomFormationSanitaire = formationSanitaire.Nom,
            //                AdresseFormationSanitaire = formationSanitaire.Adresse,
            //                TelephoneFormationSanitaire = formationSanitaire.Telephone,
            //                PrenomResponsable = formationSanitaire.ResponsablePrenom,
            //                NomResponsable = formationSanitaire.ResponsableNom
            //            };

            //return await query.ToListAsync();

            var db = this.contextFactory.CreateDbContext();
            var query = db.FormationSanitaires.Where(x => x.Nom.ToLower().IndexOf(nom.ToLower()) >= 0)
                                              .Select(x => new FormationSanitaireDto
                                              {
                                                  NomZoneDeSante = x.ZoneDeSante.Nom,
                                                  NomFormationSanitaire = x.Nom,
                                                  AdresseFormationSanitaire = x.Adresse,
                                                  PrenomResponsable = x.ResponsablePrenom,
                                                  NomResponsable = x.ResponsableNom
                                              });

            return await query.ToListAsync();
        }
    }
}
