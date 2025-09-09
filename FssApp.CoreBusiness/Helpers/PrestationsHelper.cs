using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.CoreBusiness.Helpers
{
    public class PrestationsHelper
    {
        public PrestationsSynthese Prestation { get; set; } = new();
        public Prestataire? Prestataire { get; set; } = new();
        public PrestationCategorie? PrestationCategorie { get; set; } = new();
        public FormationSanitaireDto? FormationSanitaireDto { get; set; } = new();
        public Annee? Annee { get; set; } = new();
        public Moi? Mois { get; set; } = new();
        public Monnaie? Monnaie { get; set; } = new();
    }
}
