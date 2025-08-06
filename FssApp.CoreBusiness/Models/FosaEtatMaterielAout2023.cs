using System;
using System.Collections.Generic;

namespace FssApp.CoreBusiness.Models;

public partial class FosaEtatMaterielAout2023
{
    public int FormationSanitaireId { get; set; }

    public int? NombreDeLitsHopital { get; set; }

    public int? NombreDeLitsMaternite { get; set; }

    public string? SalleAccouchementAvecTableAccouchement { get; set; }

    public string? EtatTableAccouchement { get; set; }

    public string? ObservationEtatTableAccouchement { get; set; }

    public string? SalleDeTravail { get; set; }

    public int? NombreDeLitsSalleDeTravail { get; set; }

    public string? SallePostpartum { get; set; }

    public int? NombreDeLitsSallePostpartum { get; set; }

    public string? TrouAplacenta { get; set; }

    public string? ObservationTrouAplacenta { get; set; }

    public string? Toilettes { get; set; }

    public string? DisponibiliteEau { get; set; }

    public string? ObservationDisponibiliteEau { get; set; }

    public string? Echographe { get; set; }

    public string? ObservationEchographe { get; set; }

    public string? LampeScialitiqueFonctionnelle { get; set; }

    public string? LampeChauffanteFonctionnelle { get; set; }

    public string? SourceEnergieSnel { get; set; }

    public string? SourceEnergieGroupeElectrogene { get; set; }

    public string? SourceEnergiePanneauSolaire { get; set; }

    public string? ObservationSourceEnergie { get; set; }

    public int? NombreSagesFemmesFormees { get; set; }

    public int? NombreAnesthesistesPermanents { get; set; }

    public virtual FormationSanitaire FormationSanitaire { get; set; } = null!;
}
