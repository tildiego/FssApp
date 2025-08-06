using System;
using System.Collections.Generic;
using FssApp.CoreBusiness.Models;
using Microsoft.EntityFrameworkCore;

namespace FssApp.Plugins.EFCoreSqlServer;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AireDeSante> AireDeSantes { get; set; }

    public virtual DbSet<Annee> Annees { get; set; }

    public virtual DbSet<Commune> Communes { get; set; }

    public virtual DbSet<CpnAout2023> CpnAout2023s { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<FormationSanitaire> FormationSanitaires { get; set; }

    public virtual DbSet<FosaDeletedByArcCsu> FosaDeletedByArcCsus { get; set; }

    public virtual DbSet<FosaEtatMaterielAout2023> FosaEtatMaterielAout2023s { get; set; }

    public virtual DbSet<FosaKongoCentralOld> FosaKongoCentralOlds { get; set; }

    public virtual DbSet<Intermediaire> Intermediaires { get; set; }

    public virtual DbSet<Moi> Mois { get; set; }

    public virtual DbSet<Monnaie> Monnaies { get; set; }

    public virtual DbSet<Prestataire> Prestataires { get; set; }

    public virtual DbSet<PrestationCategorie> PrestationCategories { get; set; }

    public virtual DbSet<PrestationsNeonatologie> PrestationsNeonatologies { get; set; }

    public virtual DbSet<PrestationsPaiement> PrestationsPaiements { get; set; }

    public virtual DbSet<PrestationsSynthese> PrestationsSyntheses { get; set; }

    public virtual DbSet<PrestationsSyntheseHr> PrestationsSyntheseHrs { get; set; }

    public virtual DbSet<Province> Provinces { get; set; }

    public virtual DbSet<Quartier> Quartiers { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<TypeFormationSanitaire> TypeFormationSanitaires { get; set; }

    public virtual DbSet<VwAireDeSante> VwAireDeSantes { get; set; }

    public virtual DbSet<VwFormationSanitaire> VwFormationSanitaires { get; set; }

    public virtual DbSet<VwFormationSanitaireAvecGratuiteEffective> VwFormationSanitaireAvecGratuiteEffectives { get; set; }

    public virtual DbSet<VwFormationSanitaireConventionneeKinshasa> VwFormationSanitaireConventionneeKinshasas { get; set; }

    public virtual DbSet<VwFormationSanitaireKasaiOriental> VwFormationSanitaireKasaiOrientals { get; set; }

    public virtual DbSet<VwFormationSanitaireKcKisantu> VwFormationSanitaireKcKisantus { get; set; }

    public virtual DbSet<VwFormationSanitaireKcMatadi> VwFormationSanitaireKcMatadis { get; set; }

    public virtual DbSet<VwFormationSanitaireKinshasa> VwFormationSanitaireKinshasas { get; set; }

    public virtual DbSet<VwFormationSanitaireKongoCentral> VwFormationSanitaireKongoCentrals { get; set; }

    public virtual DbSet<VwFormationSanitaireNonConventionneeKinshasa> VwFormationSanitaireNonConventionneeKinshasas { get; set; }

    public virtual DbSet<VwFormationSanitaireToBeDeleted> VwFormationSanitaireToBeDeleteds { get; set; }

    public virtual DbSet<VwPrestationsNeonatologie> VwPrestationsNeonatologies { get; set; }

    public virtual DbSet<VwPrestationsNeonatologieSumCoutTotalVerifie> VwPrestationsNeonatologieSumCoutTotalVerifies { get; set; }

    public virtual DbSet<VwPrestationsPaiement> VwPrestationsPaiements { get; set; }

    public virtual DbSet<VwPrestationsPaiementSumMontantPayeUsd> VwPrestationsPaiementSumMontantPayeUsds { get; set; }

    public virtual DbSet<VwPrestationsPaiementSummaryHr> VwPrestationsPaiementSummaryHrs { get; set; }

    public virtual DbSet<VwPrestationsPaiementSummaryParDistrict> VwPrestationsPaiementSummaryParDistricts { get; set; }

    public virtual DbSet<VwPrestationsPopulationCible> VwPrestationsPopulationCibles { get; set; }

    public virtual DbSet<VwPrestationsSynthese> VwPrestationsSyntheses { get; set; }

    public virtual DbSet<VwPrestationsSyntheseHrsSumCoutTotalVerifie> VwPrestationsSyntheseHrsSumCoutTotalVerifies { get; set; }

    public virtual DbSet<VwPrestationsSyntheseHrsSummaryParFosa> VwPrestationsSyntheseHrsSummaryParFosas { get; set; }

    public virtual DbSet<VwPrestationsSyntheseKasaiOriental> VwPrestationsSyntheseKasaiOrientals { get; set; }

    public virtual DbSet<VwPrestationsSyntheseKcKisantu> VwPrestationsSyntheseKcKisantus { get; set; }

    public virtual DbSet<VwPrestationsSyntheseKcMatadi> VwPrestationsSyntheseKcMatadis { get; set; }

    public virtual DbSet<VwPrestationsSyntheseKinshasa> VwPrestationsSyntheseKinshasas { get; set; }

    public virtual DbSet<VwPrestationsSyntheseKongoCentral> VwPrestationsSyntheseKongoCentrals { get; set; }

    public virtual DbSet<VwPrestationsSyntheseNeonatSummaryParFosa> VwPrestationsSyntheseNeonatSummaryParFosas { get; set; }

    public virtual DbSet<VwPrestationsSyntheseSumCoutTotalVerifie> VwPrestationsSyntheseSumCoutTotalVerifies { get; set; }

    public virtual DbSet<VwPrestationsSyntheseSumCoutTotalVerifieUpToFevrier> VwPrestationsSyntheseSumCoutTotalVerifieUpToFevriers { get; set; }

    public virtual DbSet<VwPrestationsSyntheseSummaryHrsNeonat> VwPrestationsSyntheseSummaryHrsNeonats { get; set; }

    public virtual DbSet<VwPrestationsSyntheseSummaryKasaiOriental> VwPrestationsSyntheseSummaryKasaiOrientals { get; set; }

    public virtual DbSet<VwPrestationsSyntheseSummaryKinshasa> VwPrestationsSyntheseSummaryKinshasas { get; set; }

    public virtual DbSet<VwPrestationsSyntheseSummaryKongoCentral> VwPrestationsSyntheseSummaryKongoCentrals { get; set; }

    public virtual DbSet<VwPropositionsIdentifiant> VwPropositionsIdentifiants { get; set; }

    public virtual DbSet<VwZoneDeSanteKisantu> VwZoneDeSanteKisantus { get; set; }

    public virtual DbSet<VwZoneDeSanteMatadi> VwZoneDeSanteMatadis { get; set; }

    public virtual DbSet<VwZoneDeSanteMbujiMayi> VwZoneDeSanteMbujiMayis { get; set; }

    public virtual DbSet<ZoneDeSante> ZoneDeSantes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=FssAppConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AireDeSante>(entity =>
        {
            entity.ToTable("AireDeSante");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSante_ID");
        });

        modelBuilder.Entity<Annee>(entity =>
        {
            entity.ToTable("Annee");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nom).HasMaxLength(4);
        });

        modelBuilder.Entity<Commune>(entity =>
        {
            entity.ToTable("Commune");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodePostal).HasMaxLength(10);
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
        });

        modelBuilder.Entity<CpnAout2023>(entity =>
        {
            entity.ToTable("CPN_AOUT_2023");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cpn1).HasColumnName("CPN1");
            entity.Property(e => e.Cpn2).HasColumnName("CPN2");
            entity.Property(e => e.Cpn3).HasColumnName("CPN3");
            entity.Property(e => e.Cpn4).HasColumnName("CPN4");
            entity.Property(e => e.FormationSanitaireId).HasColumnName("FormationSanitaire_ID");

            entity.HasOne(d => d.FormationSanitaire).WithMany(p => p.CpnAout2023s)
                .HasForeignKey(d => d.FormationSanitaireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CPN_AOUT_2023_FormationSanitaire");
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.ToTable("District");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FssCode).HasMaxLength(10);
            entity.Property(e => e.Nom).HasMaxLength(50);
            entity.Property(e => e.ProvinceId).HasColumnName("Province_ID");
            entity.Property(e => e.TypeEntite).HasMaxLength(50);

            entity.HasOne(d => d.Province).WithMany(p => p.Districts)
                .HasForeignKey(d => d.ProvinceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_District_Province");
        });

        modelBuilder.Entity<FormationSanitaire>(entity =>
        {
            entity.ToTable("FormationSanitaire");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.AireDeSante).HasMaxLength(50);
            entity.Property(e => e.CompteBanquaireCdf)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireCDF");
            entity.Property(e => e.CompteBanquaireUs)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireUS");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.IntermediaireId).HasColumnName("Intermediaire_ID");
            entity.Property(e => e.IntituleCompteBanquaire)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nom).HasMaxLength(100);
            entity.Property(e => e.NomBanque).HasMaxLength(20);
            entity.Property(e => e.ResponsableEmail).HasMaxLength(20);
            entity.Property(e => e.ResponsableNom).HasMaxLength(20);
            entity.Property(e => e.ResponsablePostNom).HasMaxLength(20);
            entity.Property(e => e.ResponsablePrenom).HasMaxLength(20);
            entity.Property(e => e.ResponsableTelephone)
                .HasMaxLength(20)
                .HasColumnName("responsableTelephone");
            entity.Property(e => e.Statut).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.ToBeDeleted).HasDefaultValue(false);
            entity.Property(e => e.TypeFormationSanitaireId).HasColumnName("TypeFormationSanitaire_ID");
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSante_ID");

            entity.HasOne(d => d.Intermediaire).WithMany(p => p.FormationSanitaires)
                .HasForeignKey(d => d.IntermediaireId)
                .HasConstraintName("FK_FormationSanitaire_Intermediaire");

            entity.HasOne(d => d.TypeFormationSanitaire).WithMany(p => p.FormationSanitaires)
                .HasForeignKey(d => d.TypeFormationSanitaireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormationSanitaire_TypeFormationSanitaire");

            entity.HasOne(d => d.ZoneDeSante).WithMany(p => p.FormationSanitaires)
                .HasForeignKey(d => d.ZoneDeSanteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FormationSanitaire_ZoneDeSante");
        });

        modelBuilder.Entity<FosaDeletedByArcCsu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Fosa_Deleted_By_ARC_CSU");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.CompteBanquaireCdf)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireCDF");
            entity.Property(e => e.CompteBanquaireUs)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireUS");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Nom).HasMaxLength(100);
            entity.Property(e => e.NomBanque).HasMaxLength(20);
            entity.Property(e => e.ResponsableEmail).HasMaxLength(20);
            entity.Property(e => e.ResponsableNom).HasMaxLength(20);
            entity.Property(e => e.ResponsablePostNom).HasMaxLength(20);
            entity.Property(e => e.ResponsablePrenom).HasMaxLength(20);
            entity.Property(e => e.ResponsableTelephone)
                .HasMaxLength(20)
                .HasColumnName("responsableTelephone");
            entity.Property(e => e.Statut).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.TypeFormationSanitaireId).HasColumnName("TypeFormationSanitaire_ID");
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSante_ID");
        });

        modelBuilder.Entity<FosaEtatMaterielAout2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FOSA_ETAT_MATERIEL_AOUT_2023");

            entity.Property(e => e.DisponibiliteEau).HasMaxLength(20);
            entity.Property(e => e.Echographe).HasMaxLength(20);
            entity.Property(e => e.EtatTableAccouchement).HasMaxLength(20);
            entity.Property(e => e.FormationSanitaireId)
                .ValueGeneratedOnAdd()
                .HasColumnName("FormationSanitaire_ID");
            entity.Property(e => e.LampeChauffanteFonctionnelle).HasMaxLength(20);
            entity.Property(e => e.LampeScialitiqueFonctionnelle).HasMaxLength(20);
            entity.Property(e => e.ObservationDisponibiliteEau).HasMaxLength(200);
            entity.Property(e => e.ObservationEchographe).HasMaxLength(200);
            entity.Property(e => e.ObservationEtatTableAccouchement).HasMaxLength(200);
            entity.Property(e => e.ObservationSourceEnergie).HasMaxLength(200);
            entity.Property(e => e.ObservationTrouAplacenta)
                .HasMaxLength(200)
                .HasColumnName("ObservationTrouAPlacenta");
            entity.Property(e => e.SalleAccouchementAvecTableAccouchement).HasMaxLength(20);
            entity.Property(e => e.SalleDeTravail).HasMaxLength(20);
            entity.Property(e => e.SallePostpartum).HasMaxLength(20);
            entity.Property(e => e.SourceEnergieGroupeElectrogene).HasMaxLength(20);
            entity.Property(e => e.SourceEnergiePanneauSolaire).HasMaxLength(20);
            entity.Property(e => e.SourceEnergieSnel)
                .HasMaxLength(20)
                .HasColumnName("SourceEnergieSNEL");
            entity.Property(e => e.Toilettes).HasMaxLength(20);
            entity.Property(e => e.TrouAplacenta)
                .HasMaxLength(20)
                .HasColumnName("TrouAPlacenta");

            entity.HasOne(d => d.FormationSanitaire).WithMany()
                .HasForeignKey(d => d.FormationSanitaireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FOSA_ETAT_MATERIEL_AOUT_2023_FormationSanitaire");
        });

        modelBuilder.Entity<FosaKongoCentralOld>(entity =>
        {
            entity.ToTable("FosaKongoCentral_OLD");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.AireDeSante).HasMaxLength(50);
            entity.Property(e => e.CompteBanquaireCdf)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireCDF");
            entity.Property(e => e.CompteBanquaireUs)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireUS");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.IntermediaireId).HasColumnName("Intermediaire_ID");
            entity.Property(e => e.IntituleCompteUba)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("IntituleCompteUBA");
            entity.Property(e => e.Nom).HasMaxLength(100);
            entity.Property(e => e.NomBanque).HasMaxLength(20);
            entity.Property(e => e.ResponsableEmail).HasMaxLength(20);
            entity.Property(e => e.ResponsableNom).HasMaxLength(20);
            entity.Property(e => e.ResponsablePostNom).HasMaxLength(20);
            entity.Property(e => e.ResponsablePrenom).HasMaxLength(20);
            entity.Property(e => e.ResponsableTelephone)
                .HasMaxLength(20)
                .HasColumnName("responsableTelephone");
            entity.Property(e => e.Statut).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.TypeFormationSanitaireId).HasColumnName("TypeFormationSanitaire_ID");
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSante_ID");
        });

        modelBuilder.Entity<Intermediaire>(entity =>
        {
            entity.ToTable("Intermediaire");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.Nom).HasMaxLength(50);
        });

        modelBuilder.Entity<Moi>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasMaxLength(10);
            entity.Property(e => e.Nom).HasMaxLength(10);
        });

        modelBuilder.Entity<Monnaie>(entity =>
        {
            entity.ToTable("Monnaie");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code).HasMaxLength(3);
            entity.Property(e => e.Nom).HasMaxLength(50);
        });

        modelBuilder.Entity<Prestataire>(entity =>
        {
            entity.ToTable("Prestataire");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Type).HasMaxLength(20);
        });

        modelBuilder.Entity<PrestationCategorie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PretationCategorie");

            entity.ToTable("PrestationCategorie");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nom).HasMaxLength(50);
        });

        modelBuilder.Entity<PrestationsNeonatologie>(entity =>
        {
            entity.ToTable("PrestationsNeonatologie");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnneeId).HasColumnName("Annee_ID");
            entity.Property(e => e.CoutTotalDeclare)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutTotalVerifie)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FormationSanitaireId).HasColumnName("FormationSanitaire_ID");
            entity.Property(e => e.MoisId).HasColumnName("Mois_ID");
            entity.Property(e => e.NomDuPatient).HasMaxLength(50);
            entity.Property(e => e.PrestationCategorieId).HasColumnName("PrestationCategorie_ID");

            entity.HasOne(d => d.Annee).WithMany(p => p.PrestationsNeonatologies)
                .HasForeignKey(d => d.AnneeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsNeonatologie_Annee");

            entity.HasOne(d => d.FormationSanitaire).WithMany(p => p.PrestationsNeonatologies)
                .HasForeignKey(d => d.FormationSanitaireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsNeonatologie_FormationSanitaire");

            entity.HasOne(d => d.Mois).WithMany(p => p.PrestationsNeonatologies)
                .HasForeignKey(d => d.MoisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsNeonatologie_Mois");

            entity.HasOne(d => d.PrestationCategorie).WithMany(p => p.PrestationsNeonatologies)
                .HasForeignKey(d => d.PrestationCategorieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsNeonatologie_PrestationCategorie");
        });

        modelBuilder.Entity<PrestationsPaiement>(entity =>
        {
            entity.ToTable("PrestationsPaiement");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnneeId).HasColumnName("Annee_ID");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.FormationSanitaireId).HasColumnName("FormationSanitaire_ID");
            entity.Property(e => e.MoisId).HasColumnName("Mois_ID");
            entity.Property(e => e.MontantPayeUsd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MontantPayeUSD");

            entity.HasOne(d => d.Annee).WithMany(p => p.PrestationsPaiements)
                .HasForeignKey(d => d.AnneeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsPaiement_Annee");

            entity.HasOne(d => d.FormationSanitaire).WithMany(p => p.PrestationsPaiements)
                .HasForeignKey(d => d.FormationSanitaireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsPaiement_FormationSanitaire");

            entity.HasOne(d => d.Mois).WithMany(p => p.PrestationsPaiements)
                .HasForeignKey(d => d.MoisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsPaiement_Mois");
        });

        modelBuilder.Entity<PrestationsSynthese>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PrestationSynthese");

            entity.ToTable("PrestationsSynthese");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnneeId).HasColumnName("Annee_ID");
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FormationSanitaireId).HasColumnName("FormationSanitaire_ID");
            entity.Property(e => e.MoisId).HasColumnName("Mois_ID");
            entity.Property(e => e.MonnaieId).HasColumnName("Monnaie_ID");
            entity.Property(e => e.PrestataireId).HasColumnName("Prestataire_ID");
            entity.Property(e => e.PrestationCategorieId).HasColumnName("PrestationCategorie_ID");
            entity.Property(e => e.ServiceId).HasColumnName("Service_ID");

            entity.HasOne(d => d.Annee).WithMany(p => p.PrestationsSyntheses)
                .HasForeignKey(d => d.AnneeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSynthese_Annee");

            entity.HasOne(d => d.FormationSanitaire).WithMany(p => p.PrestationsSyntheses)
                .HasForeignKey(d => d.FormationSanitaireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSynthese_FormationSanitaire");

            entity.HasOne(d => d.Mois).WithMany(p => p.PrestationsSyntheses)
                .HasForeignKey(d => d.MoisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSynthese_Mois");

            entity.HasOne(d => d.Monnaie).WithMany(p => p.PrestationsSyntheses)
                .HasForeignKey(d => d.MonnaieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSynthese_Monnaie");

            entity.HasOne(d => d.Prestataire).WithMany(p => p.PrestationsSyntheses)
                .HasForeignKey(d => d.PrestataireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSynthese_Prestataire");

            entity.HasOne(d => d.PrestationCategorie).WithMany(p => p.PrestationsSyntheses)
                .HasForeignKey(d => d.PrestationCategorieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSynthese_PrestationCategorie");

            entity.HasOne(d => d.Service).WithMany(p => p.PrestationsSyntheses)
                .HasForeignKey(d => d.ServiceId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSynthese_Service");
        });

        modelBuilder.Entity<PrestationsSyntheseHr>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PrestationSyntheseHRS");

            entity.ToTable("PrestationsSyntheseHRS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnneeId).HasColumnName("Annee_ID");
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FormationSanitaireId).HasColumnName("FormationSanitaire_ID");
            entity.Property(e => e.MoisId).HasColumnName("Mois_ID");
            entity.Property(e => e.PrestataireId).HasColumnName("Prestataire_ID");
            entity.Property(e => e.PrestationCategorieId).HasColumnName("PrestationCategorie_ID");

            entity.HasOne(d => d.Annee).WithMany(p => p.PrestationsSyntheseHrs)
                .HasForeignKey(d => d.AnneeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSyntheseHRS_Annee");

            entity.HasOne(d => d.FormationSanitaire).WithMany(p => p.PrestationsSyntheseHrs)
                .HasForeignKey(d => d.FormationSanitaireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSyntheseHRS_FormationSanitaire");

            entity.HasOne(d => d.Mois).WithMany(p => p.PrestationsSyntheseHrs)
                .HasForeignKey(d => d.MoisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSyntheseHRS_Mois");

            entity.HasOne(d => d.Prestataire).WithMany(p => p.PrestationsSyntheseHrs)
                .HasForeignKey(d => d.PrestataireId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSyntheseHRS_Prestataire");

            entity.HasOne(d => d.PrestationCategorie).WithMany(p => p.PrestationsSyntheseHrs)
                .HasForeignKey(d => d.PrestationCategorieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PrestationsSyntheseHRS_PrestationCategorie");
        });

        modelBuilder.Entity<Province>(entity =>
        {
            entity.ToTable("Province");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AncienNom).HasMaxLength(50);
            entity.Property(e => e.Capitale).HasMaxLength(50);
            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.CodePostal).HasMaxLength(10);
            entity.Property(e => e.FuseauHoraire).HasMaxLength(10);
            entity.Property(e => e.Nom).HasMaxLength(50);
        });

        modelBuilder.Entity<Quartier>(entity =>
        {
            entity.ToTable("Quartier");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodePostal).HasMaxLength(10);
            entity.Property(e => e.CommuneId).HasColumnName("Commune_Id");
            entity.Property(e => e.Nom).HasMaxLength(50);
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.ToTable("Service");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nom).HasMaxLength(50);
        });

        modelBuilder.Entity<TypeFormationSanitaire>(entity =>
        {
            entity.ToTable("TypeFormationSanitaire");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code).HasMaxLength(10);
            entity.Property(e => e.Nom).HasMaxLength(50);
        });

        modelBuilder.Entity<VwAireDeSante>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwAireDeSante");

            entity.Property(e => e.AireDeSante).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwFormationSanitaire>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFormationSanitaire");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaConventionnee)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.IntituleCompteBanquaire)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ResponsableEmail).HasMaxLength(20);
            entity.Property(e => e.ResponsableNom).HasMaxLength(20);
            entity.Property(e => e.ResponsablePostNom).HasMaxLength(20);
            entity.Property(e => e.ResponsablePrenom).HasMaxLength(20);
            entity.Property(e => e.ResponsableTelephone)
                .HasMaxLength(20)
                .HasColumnName("responsableTelephone");
            entity.Property(e => e.Statut).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwFormationSanitaireAvecGratuiteEffective>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFormationSanitaire_Avec_Gratuite_Effective");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaNomAlternatif)
                .HasMaxLength(100)
                .HasColumnName("Fosa nom alternatif");
            entity.Property(e => e.Intermediaire).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSanté)
                .HasMaxLength(50)
                .HasColumnName("Zone de santé");
        });

        modelBuilder.Entity<VwFormationSanitaireConventionneeKinshasa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFormationSanitaire_Conventionnee_Kinshasa");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.NomDuResponsable)
                .HasMaxLength(62)
                .HasColumnName("Nom du responsable");
            entity.Property(e => e.NumTéléphoneDuResponsable)
                .HasMaxLength(20)
                .HasColumnName("Num. Téléphone du responsable");
            entity.Property(e => e.Statut).HasMaxLength(20);
            entity.Property(e => e.TypeFosa)
                .HasMaxLength(10)
                .HasColumnName("Type Fosa");
            entity.Property(e => e.Téléphone).HasMaxLength(20);
            entity.Property(e => e.ZoneDeSanté)
                .HasMaxLength(50)
                .HasColumnName("Zone de santé");
        });

        modelBuilder.Entity<VwFormationSanitaireKasaiOriental>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFormationSanitaire_KASAI_ORIENTAL");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.CompteBanquaireCdf)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireCDF");
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaConventionnee)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.IntituleCompteBanquaire)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ResponsableTelephone)
                .HasMaxLength(20)
                .HasColumnName("responsableTelephone");
            entity.Property(e => e.Statut).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.Territoire).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSante_ID");
        });

        modelBuilder.Entity<VwFormationSanitaireKcKisantu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFormationSanitaire_KC_KISANTU");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.CompteBanquaireCdf)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireCDF");
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaConventionnee)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.IntituleCompteBanquaire)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ResponsableTelephone)
                .HasMaxLength(20)
                .HasColumnName("responsableTelephone");
            entity.Property(e => e.Statut).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.Territoire).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwFormationSanitaireKcMatadi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFormationSanitaire_KC_MATADI");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.CompteBanquaireCdf)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireCDF");
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaConventionnee)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.IntituleCompteBanquaire)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ResponsableTelephone)
                .HasMaxLength(20)
                .HasColumnName("responsableTelephone");
            entity.Property(e => e.Statut).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.Territoire).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwFormationSanitaireKinshasa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFormationSanitaire_KINSHASA");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.IntituleCompteBanquaire)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ResponsableTelephone)
                .HasMaxLength(20)
                .HasColumnName("responsableTelephone");
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwFormationSanitaireKongoCentral>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFormationSanitaire_KONGO_CENTRAL");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.CompteBanquaireCdf)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireCDF");
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaConventionnee)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.IntituleCompteBanquaire)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ResponsableTelephone)
                .HasMaxLength(20)
                .HasColumnName("responsableTelephone");
            entity.Property(e => e.Statut).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.Territoire).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSante_ID");
        });

        modelBuilder.Entity<VwFormationSanitaireNonConventionneeKinshasa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFormationSanitaire_NON_Conventionnee_Kinshasa");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.FosaNomAlternatif)
                .HasMaxLength(100)
                .HasColumnName("Fosa nom alternatif");
            entity.Property(e => e.Intermediaire).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSanté)
                .HasMaxLength(50)
                .HasColumnName("Zone de santé");
        });

        modelBuilder.Entity<VwFormationSanitaireToBeDeleted>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwFormationSanitaire_To_Be_Deleted");

            entity.Property(e => e.Adresse).HasMaxLength(100);
            entity.Property(e => e.CompteBanquaireCdf)
                .HasMaxLength(50)
                .HasColumnName("CompteBanquaireCDF");
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaConventionnee)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.IntituleCompteBanquaire)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ResponsableTelephone)
                .HasMaxLength(20)
                .HasColumnName("responsableTelephone");
            entity.Property(e => e.Statut).HasMaxLength(20);
            entity.Property(e => e.Telephone).HasMaxLength(20);
            entity.Property(e => e.Territoire).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSante_ID");
        });

        modelBuilder.Entity<VwPrestationsNeonatologie>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsNeonatologie");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.PrestationCategorie).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPrestationsNeonatologieSumCoutTotalVerifie>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsNeonatologie_Sum_CoutTotalVerifie");

            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
        });

        modelBuilder.Entity<VwPrestationsPaiement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsPaiement");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.IntituleCompteBanquaire)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Libelle).HasMaxLength(200);
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.MoisAnnee).HasMaxLength(15);
            entity.Property(e => e.MontantPayeUsd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MontantPayeUSD");
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPrestationsPaiementSumMontantPayeUsd>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsPaiement_Sum_MontantPayeUSD");

            entity.Property(e => e.FormationSanitaireId).HasColumnName("FormationSanitaire_ID");
            entity.Property(e => e.MontantPayeUsd)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("MontantPayeUSD");
        });

        modelBuilder.Entity<VwPrestationsPaiementSummaryHr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsPaiement_Summary_HRS");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.MontantPayeUsd)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("MontantPayeUSD");
        });

        modelBuilder.Entity<VwPrestationsPaiementSummaryParDistrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsPaiement_Summary_Par_District");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.MontantsPayeesUsd)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("MontantsPayeesUSD");
        });

        modelBuilder.Entity<VwPrestationsPopulationCible>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsPopulationCible");

            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.Nom).HasMaxLength(100);
            entity.Property(e => e.NomZoneDeSante).HasMaxLength(50);
            entity.Property(e => e.TypeFosaId).HasColumnName("TypeFosaID");
        });

        modelBuilder.Entity<VwPrestationsSynthese>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.MoisAnnee).HasMaxLength(15);
            entity.Property(e => e.MoisId).HasColumnName("MoisID");
            entity.Property(e => e.Monnaie).HasMaxLength(3);
            entity.Property(e => e.Prestataire).HasMaxLength(20);
            entity.Property(e => e.PrestationCategorie).HasMaxLength(50);
            entity.Property(e => e.PrestationId).HasColumnName("PrestationID");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSanteID");
        });

        modelBuilder.Entity<VwPrestationsSyntheseHrsSumCoutTotalVerifie>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSyntheseHRS_Sum_CoutTotalVerifie");

            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.FormationSanitaireId).HasColumnName("FormationSanitaire_ID");
        });

        modelBuilder.Entity<VwPrestationsSyntheseHrsSummaryParFosa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSyntheseHRS_Summary_Par_Fosa");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.Mois).HasMaxLength(10);
        });

        modelBuilder.Entity<VwPrestationsSyntheseKasaiOriental>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_KASAI_ORIENTAL");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.MoisAnnee).HasMaxLength(15);
            entity.Property(e => e.Monnaie).HasMaxLength(3);
            entity.Property(e => e.Prestataire).HasMaxLength(20);
            entity.Property(e => e.PrestationCategorie).HasMaxLength(50);
            entity.Property(e => e.PrestationId).HasColumnName("PrestationID");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPrestationsSyntheseKcKisantu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_KC_KISANTU");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.MoisAnnee).HasMaxLength(15);
            entity.Property(e => e.Monnaie).HasMaxLength(3);
            entity.Property(e => e.Prestataire).HasMaxLength(20);
            entity.Property(e => e.PrestationCategorie).HasMaxLength(50);
            entity.Property(e => e.PrestationId).HasColumnName("PrestationID");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPrestationsSyntheseKcMatadi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_KC_MATADI");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.MoisAnnee).HasMaxLength(15);
            entity.Property(e => e.Monnaie).HasMaxLength(3);
            entity.Property(e => e.Prestataire).HasMaxLength(20);
            entity.Property(e => e.PrestationCategorie).HasMaxLength(50);
            entity.Property(e => e.PrestationId).HasColumnName("PrestationID");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPrestationsSyntheseKinshasa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_KINSHASA");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.MoisAnnee).HasMaxLength(15);
            entity.Property(e => e.Monnaie).HasMaxLength(3);
            entity.Property(e => e.Prestataire).HasMaxLength(20);
            entity.Property(e => e.PrestationCategorie).HasMaxLength(50);
            entity.Property(e => e.PrestationId).HasColumnName("PrestationID");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPrestationsSyntheseKongoCentral>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_KONGO_CENTRAL");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireDeclare).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CoutUnitaireVerifie).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaId).HasColumnName("FosaID");
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.MoisAnnee).HasMaxLength(15);
            entity.Property(e => e.Monnaie).HasMaxLength(3);
            entity.Property(e => e.Prestataire).HasMaxLength(20);
            entity.Property(e => e.PrestationCategorie).HasMaxLength(50);
            entity.Property(e => e.PrestationId).HasColumnName("PrestationID");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Service).HasMaxLength(50);
            entity.Property(e => e.TypeFosa).HasMaxLength(10);
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPrestationsSyntheseNeonatSummaryParFosa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_NEONAT_Summary_Par_Fosa");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.Mois).HasMaxLength(10);
        });

        modelBuilder.Entity<VwPrestationsSyntheseSumCoutTotalVerifie>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_Sum_CoutTotalVerifie");

            entity.Property(e => e.AnneeId).HasColumnName("Annee_ID");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.FormationSanitaireId).HasColumnName("FormationSanitaire_ID");
            entity.Property(e => e.MoisId).HasColumnName("Mois_ID");
        });

        modelBuilder.Entity<VwPrestationsSyntheseSumCoutTotalVerifieUpToFevrier>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_Sum_CoutTotalVerifie_UP_TO_FEVRIER");

            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.FormationSanitaireId).HasColumnName("FormationSanitaire_ID");
        });

        modelBuilder.Entity<VwPrestationsSyntheseSummaryHrsNeonat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_Summary_HRS_NEONAT");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.Mois).HasMaxLength(10);
        });

        modelBuilder.Entity<VwPrestationsSyntheseSummaryKasaiOriental>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_Summary_KASAI_ORIENTAL");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Mois).HasMaxLength(10);
            entity.Property(e => e.Province).HasMaxLength(50);
        });

        modelBuilder.Entity<VwPrestationsSyntheseSummaryKinshasa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_Summary_KINSHASA");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Mois).HasMaxLength(10);
        });

        modelBuilder.Entity<VwPrestationsSyntheseSummaryKongoCentral>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPrestationsSynthese_Summary_KONGO_CENTRAL");

            entity.Property(e => e.Annee).HasMaxLength(4);
            entity.Property(e => e.CoutTotalDeclare).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.CoutTotalVerifie).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.District)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.Mois).HasMaxLength(10);
        });

        modelBuilder.Entity<VwPropositionsIdentifiant>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwPROPOSITIONS_IDENTIFIANTS");

            entity.Property(e => e.Dcode)
                .HasMaxLength(3)
                .HasColumnName("DCode");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Fosa).HasMaxLength(100);
            entity.Property(e => e.FosaCode1).HasMaxLength(4000);
            entity.Property(e => e.FosaCode2).HasMaxLength(4000);
            entity.Property(e => e.FosaCode3).HasMaxLength(4000);
            entity.Property(e => e.FosaCode4).HasMaxLength(4000);
            entity.Property(e => e.FosaCode5).HasMaxLength(4000);
            entity.Property(e => e.FosaNomAlternatif)
                .HasMaxLength(100)
                .HasColumnName("Fosa nom alternatif");
            entity.Property(e => e.Pcode)
                .HasMaxLength(10)
                .HasColumnName("PCode");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.TypeDeFosa)
                .HasMaxLength(10)
                .HasColumnName("Type de Fosa");
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
            entity.Property(e => e.ZsCode1)
                .HasMaxLength(4)
                .HasColumnName("ZS_CODE1");
            entity.Property(e => e.ZsCode2)
                .HasMaxLength(4)
                .HasColumnName("ZS_CODE2");
            entity.Property(e => e.ZsCode3)
                .HasMaxLength(4)
                .HasColumnName("ZS_CODE3");
        });

        modelBuilder.Entity<VwZoneDeSanteKisantu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwZoneDeSante_KISANTU");

            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.VilleTerritoireDistrict)
                .HasMaxLength(50)
                .HasColumnName("Ville/Territoire/District");
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSanteID");
        });

        modelBuilder.Entity<VwZoneDeSanteMatadi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwZoneDeSante_MATADI");

            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.VilleTerritoireDistrict)
                .HasMaxLength(50)
                .HasColumnName("Ville/Territoire/District");
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSanteID");
        });

        modelBuilder.Entity<VwZoneDeSanteMbujiMayi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwZoneDeSante_Mbuji_Mayi");

            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.VilleTerritoireDistrict)
                .HasMaxLength(50)
                .HasColumnName("Ville/Territoire/District");
            entity.Property(e => e.ZoneDeSante).HasMaxLength(50);
            entity.Property(e => e.ZoneDeSanteId).HasColumnName("ZoneDeSanteID");
        });

        modelBuilder.Entity<ZoneDeSante>(entity =>
        {
            entity.ToTable("ZoneDeSante");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DistrictId).HasColumnName("District_ID");
            entity.Property(e => e.FssCode).HasMaxLength(10);
            entity.Property(e => e.Nom).HasMaxLength(50);

            entity.HasOne(d => d.District).WithMany(p => p.ZoneDeSantes)
                .HasForeignKey(d => d.DistrictId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ZoneDeSante_District");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
