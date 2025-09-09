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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FssApp.Plugins.EFCoreSqlServer
{
    public class FosaEFCoreRepository : IFosaEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public FosaEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task AddFosaAsync(FormationSanitaire formationSanitaire)
        {
            using var db = this.contextFactory.CreateDbContext();
            db.FormationSanitaires.Add(formationSanitaire);
            await db.SaveChangesAsync();
        }

        public async Task DeleteFosaByIdAsync(int fosaId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var fosaASupprimer = await db.FormationSanitaires.FindAsync(fosaId);

            if (fosaASupprimer is null) return;

            db.FormationSanitaires.Remove(fosaASupprimer);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<FormationSanitaireDto>> GetAllAsync()
        {
            var db = this.contextFactory.CreateDbContext();
            var query = from fosa in db.FormationSanitaires
                        join district in db.Districts on fosa.ZoneDeSante.DistrictId equals district.Id
                        join province in db.Provinces on district.ProvinceId equals province.Id
                        join typeFosa in db.TypeFormationSanitaires on fosa.TypeFormationSanitaireId equals typeFosa.Id
                        orderby fosa.Nom
                        select new FormationSanitaireDto
                        {
                            Province = province.Nom,
                            District = district.Nom,
                            ZoneDeSante = fosa.ZoneDeSante.Nom,
                            TypeFosa = typeFosa.Code,
                            FosaId = fosa.Id,
                            Fosa = fosa.Nom,
                            Description = fosa.Description,
                            Adresse = fosa.Adresse,
                            Telephone = fosa.Telephone,
                            ResponsableNom = fosa.ResponsableNom,
                            ResponsablePostNom = fosa.ResponsablePostNom,
                            ResponsablePrenom = fosa.ResponsablePrenom,
                            ResponsableEmail = fosa.ResponsableEmail,
                            ResponsableTelephone = fosa.ResponsableTelephone,
                            FosaConventionnee = fosa.FosaConventionnee ? true : false,
                            Statut = fosa.Statut,
                            ToBeDeleted = fosa.ToBeDeleted
                        };
           
            return await query.ToListAsync();
        }

        public async Task<IEnumerable<FormationSanitaire>> GetAllFosaAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            var listefosas = db.FormationSanitaires
                         .Include(f => f.TypeFormationSanitaire)
                         .Include(f => f.ZoneDeSante)
                         .ThenInclude(z => z.District)
                         .ThenInclude(d => d.Province);

            if (listefosas is null)
                return new List<FormationSanitaire>();

            foreach (var fosa in listefosas)
            {
                if(fosa.ZoneDeSante.FormationSanitaires is not null)
                    fosa.ZoneDeSante.FormationSanitaires = null;
                if (fosa.ZoneDeSante.District.ZoneDeSantes is not null)
                    fosa.ZoneDeSante.District.ZoneDeSantes = null;
                if(fosa.ZoneDeSante.District.Province.Districts is not null)
                    fosa.ZoneDeSante.District.Province.Districts = null;
                if(fosa.TypeFormationSanitaire.FormationSanitaires is not null)
                    fosa.TypeFormationSanitaire.FormationSanitaires = null;
            }

            var fosasList = await listefosas.ToListAsync();

            return fosasList;
        }

        public async Task<FormationSanitaire> GetFosaByIdAsync(int fosaId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var fosa = await db.FormationSanitaires
                         .Include(f => f.TypeFormationSanitaire)
                         .Include(f => f.ZoneDeSante)
                         .ThenInclude(z => z.District)
                         .ThenInclude(d => d.Province)
                         .FirstOrDefaultAsync(f => f.Id == fosaId);

            if (fosa is null)
                return new FormationSanitaire();

            if (fosa.ZoneDeSante.FormationSanitaires is not null)
                fosa.ZoneDeSante.FormationSanitaires = null;
            if (fosa.ZoneDeSante.District.ZoneDeSantes is not null)
                fosa.ZoneDeSante.District.ZoneDeSantes = null;
            if (fosa.ZoneDeSante.District.Province.Districts is not null)
                fosa.ZoneDeSante.District.Province.Districts = null;
            if (fosa.TypeFormationSanitaire.FormationSanitaires is not null)
                fosa.TypeFormationSanitaire.FormationSanitaires = null;

            return fosa;
        }

        public async Task UpdateFosaAsync(FormationSanitaire fosa)
        {
            using var db = this.contextFactory.CreateDbContext();
            var fosaAModifier = await db.FormationSanitaires.FindAsync(fosa.Id);

            if(fosaAModifier is not null)
            {
                fosaAModifier.Nom = fosa.Nom;
                fosaAModifier.Adresse = fosa.Adresse;
                fosaAModifier.Telephone = fosa.Telephone;
                fosaAModifier.ResponsableNom = fosa.ResponsableNom;
                fosaAModifier.ResponsablePostNom = fosa.ResponsablePostNom;
                fosaAModifier.ResponsablePrenom = fosa.ResponsablePrenom;
                fosaAModifier.ResponsableTelephone = fosa.ResponsableTelephone;
                fosaAModifier.ResponsableEmail = fosa.ResponsableEmail;
                fosaAModifier.Statut = fosa.Statut;
                fosaAModifier.FosaConventionnee = fosa.FosaConventionnee;
                fosaAModifier.TypeFormationSanitaireId = fosa.TypeFormationSanitaireId;
                fosaAModifier.ZoneDeSanteId = fosa.ZoneDeSanteId;

                await db.SaveChangesAsync();
            }   
        }
    }
}
