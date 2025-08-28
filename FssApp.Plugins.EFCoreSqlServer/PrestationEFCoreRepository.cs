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
    public class PrestationEFCoreRepository : IPrestationEFCoreRepository
    {
        private readonly IDbContextFactory<AppDbContext> contextFactory;

        public PrestationEFCoreRepository(IDbContextFactory<AppDbContext> contextFactory)
        {
            this.contextFactory = contextFactory;
        }

        public async Task AddPrestationAsync(PrestationsSynthese prestationsSynthese)
        {
            using var db = this.contextFactory.CreateDbContext();
            db.PrestationsSyntheses.Add(prestationsSynthese);
            await db.SaveChangesAsync();
        }

        public async Task DeletePrestationByIdAsync(int prestationId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var prestationASupprimer = await db.PrestationsSyntheses.FindAsync(prestationId);

            if (prestationASupprimer is null) return;

            db.PrestationsSyntheses.Remove(prestationASupprimer);
            await db.SaveChangesAsync();
        }
        public async Task<IEnumerable<PrestationDto>> GetAllAsync()
        {
            var db = this.contextFactory.CreateDbContext();
            var query = from prestation in db.PrestationsSyntheses
                        join prestataire in db.Prestataires on prestation.PrestataireId equals prestataire.Id
                        join prestationCat in db.PrestationCategories on prestation.PrestationCategorieId equals prestationCat.Id
                        join monnaie in db.Monnaies on prestation.MonnaieId equals monnaie.Id
                        join mois in db.Mois on prestation.MoisId equals mois.Id
                        join annee in db.Annees on prestation.AnneeId equals annee.Id
                        join fosa in db.FormationSanitaires on prestation.FormationSanitaireId equals fosa.Id
                        join district in db.Districts on fosa.ZoneDeSante.DistrictId equals district.Id
                        join province in db.Provinces on district.ProvinceId equals province.Id
                        join typeFosa in db.TypeFormationSanitaires on fosa.TypeFormationSanitaireId equals typeFosa.Id
                        orderby fosa.Nom
                        select new PrestationDto
                        {
                            Annee = annee.Nom,
                            Mois = mois.Nom,
                            PrestationId = prestation.Id,
                            FosaId = fosa.Id,
                            Fosa = fosa.Nom,
                            Province = province.Nom,
                            District = district.Nom,
                            ZoneDeSante = fosa.ZoneDeSante.Nom,
                            TypeFosa = typeFosa.Code,
                            Prestataire = prestation.Prestataire.Type,
                            PrestationCategorie = prestationCat.Nom,
                            Monnaie = monnaie.Code,
                            EffectifDeclare = prestation.EffectifDeclare,
                            CoutUnitaireDeclare = prestation.CoutUnitaireDeclare,
                            CoutTotalDeclare = prestation.CoutTotalDeclare,
                            EffectifVerifie = prestation.EffectifVerifie,
                            CoutUnitaireVerifie = prestation.CoutUnitaireVerifie,
                            CoutTotalVerifie = prestation.CoutTotalVerifie
                        };

            return await query.ToListAsync();
        }

        public async Task<IEnumerable<PrestationsSynthese>> GetAllPrestationsAsync()
        {
            using var db = this.contextFactory.CreateDbContext();
            var listePrestations = db.PrestationsSyntheses
            .Include(p => p.Prestataire)
                         .Include(p => p.PrestationCategorie)
                         .Include(p => p.Monnaie)
                         .Include(p => p.Mois)
                         .Include(p => p.Annee)
                         .Include(p => p.FormationSanitaire)
                         .ThenInclude(f => f.TypeFormationSanitaire)
                         .Include(p => p.FormationSanitaire)
                         .ThenInclude(f => f.ZoneDeSante)
                         .ThenInclude(z => z.District)
                         .ThenInclude(d => d.Province);

            if (listePrestations is null)
                return new List<PrestationsSynthese>();

            foreach (var prestation in listePrestations)
            {
                if (prestation.FormationSanitaire.ZoneDeSante.FormationSanitaires is not null)
                    prestation.FormationSanitaire.ZoneDeSante.FormationSanitaires = null;
                if (prestation.FormationSanitaire.ZoneDeSante.District.ZoneDeSantes is not null)
                    prestation.FormationSanitaire.ZoneDeSante.District.ZoneDeSantes = null;
                if (prestation.FormationSanitaire.ZoneDeSante.District.Province.Districts is not null)
                    prestation.FormationSanitaire.ZoneDeSante.District.Province.Districts = null;
                if (prestation.FormationSanitaire.TypeFormationSanitaire.FormationSanitaires is not null)
                    prestation.FormationSanitaire.TypeFormationSanitaire.FormationSanitaires = null;
                if (prestation.FormationSanitaire.PrestationsSyntheses is not null)
                    prestation.FormationSanitaire.PrestationsSyntheses = null;

                if (prestation.Prestataire.PrestationsSyntheses is not null)
                    prestation.Prestataire.PrestationsSyntheses = null;

                if (prestation.PrestationCategorie is not null)
                    prestation.PrestationCategorie.PrestationsSyntheses = null;

                if (prestation.Monnaie is not null)
                    prestation.Monnaie.PrestationsSyntheses = null;

                if (prestation.Mois is not null)
                    prestation.Mois.PrestationsSyntheses = null;

                if (prestation.Annee is not null)
                    prestation.Annee.PrestationsSyntheses = null;
            }

            var prestations = await listePrestations.ToListAsync();

            return prestations;
        }

        public async Task<PrestationsSynthese> GetPrestationByIdAsync(int prestationId)
        {
            using var db = this.contextFactory.CreateDbContext();
            var prestation = await db.PrestationsSyntheses
                         .Include(p => p.Prestataire)
                         .Include(p => p.PrestationCategorie)
                         .Include(p => p.Monnaie)
                         .Include(p => p.Mois)
                         .Include(p => p.Annee)
                         .Include(p => p.FormationSanitaire)
                         .ThenInclude(f => f.TypeFormationSanitaire)
                         .Include(p => p.FormationSanitaire)
                         .ThenInclude(f => f.ZoneDeSante)
                         .ThenInclude(z => z.District)
                         .ThenInclude(d => d.Province)
                         .FirstOrDefaultAsync(p => p.Id == prestationId);

            if (prestation is null)
                return new PrestationsSynthese();

            if (prestation.FormationSanitaire.ZoneDeSante.FormationSanitaires is not null)
                prestation.FormationSanitaire.ZoneDeSante.FormationSanitaires = null;
            if (prestation.FormationSanitaire.ZoneDeSante.District.ZoneDeSantes is not null)
                prestation.FormationSanitaire.ZoneDeSante.District.ZoneDeSantes = null;
            if (prestation.FormationSanitaire.ZoneDeSante.District.Province.Districts is not null)
                prestation.FormationSanitaire.ZoneDeSante.District.Province.Districts = null;
            if (prestation.FormationSanitaire.TypeFormationSanitaire.FormationSanitaires is not null)
                prestation.FormationSanitaire.TypeFormationSanitaire.FormationSanitaires = null;

            if (prestation.Prestataire.PrestationsSyntheses is not null)
                prestation.Prestataire.PrestationsSyntheses = null;

            if (prestation.PrestationCategorie is not null)
                prestation.PrestationCategorie.PrestationsSyntheses = null;

            if (prestation.Monnaie is not null)
                prestation.Monnaie.PrestationsSyntheses = null;

            if (prestation.Mois is not null)
                prestation.Mois.PrestationsSyntheses = null;

            if (prestation.Annee is not null)
                prestation.Annee.PrestationsSyntheses = null;

            return prestation;
        }

        public async Task UpdatePrestationAsync(PrestationsSynthese prestation)
        {
            using var db = this.contextFactory.CreateDbContext();
            var prestationAModifier = await db.PrestationsSyntheses.FindAsync(prestation.Id);

            if(prestationAModifier is not null)
            {
                prestationAModifier.FormationSanitaire.ZoneDeSante.District.Province.Nom = prestation.FormationSanitaire.ZoneDeSante.District.Province.Nom;
                prestationAModifier.FormationSanitaire.ZoneDeSante.District.Nom = prestation.FormationSanitaire.ZoneDeSante.District.Nom;
                prestationAModifier.FormationSanitaire.ZoneDeSante.Nom = prestation.FormationSanitaire.ZoneDeSante.Nom;
                prestationAModifier.FormationSanitaire.Nom = prestation.FormationSanitaire.Nom;
                prestationAModifier.PrestataireId = prestation.PrestataireId;
                prestationAModifier.PrestationCategorieId = prestation.PrestationCategorieId;
                prestationAModifier.MonnaieId = prestation.MonnaieId;
                prestationAModifier.CoutUnitaireDeclare = prestation.CoutUnitaireDeclare;
                prestationAModifier.EffectifDeclare = prestation.EffectifDeclare;
                prestationAModifier.CoutTotalDeclare = prestationAModifier.CoutUnitaireDeclare * prestation.EffectifDeclare;
                prestationAModifier.CoutUnitaireVerifie = prestation.CoutUnitaireVerifie;
                prestationAModifier.EffectifVerifie = prestation.EffectifVerifie;
                prestationAModifier.CoutTotalVerifie = prestationAModifier.CoutUnitaireVerifie * prestation.EffectifVerifie;
                prestationAModifier.MoisId = prestation.MoisId;
                prestationAModifier.AnneeId = prestation.AnneeId;

                if (prestation.Annee is not null && prestation.Mois is not null)
                {
                    var datetime = new DateTime(int.Parse(prestation.Annee.Nom), prestation.Mois.Id, 1);
                    var dateOnly = DateOnly.FromDateTime(datetime);
                    prestationAModifier.DatePrestation = dateOnly;
                }
                
                await db.SaveChangesAsync();
            }   
        }
    }
}
