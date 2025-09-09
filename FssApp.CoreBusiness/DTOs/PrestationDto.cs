using FssApp.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.CoreBusiness.DTOs
{
    public class PrestationDto
    {
        public int PrestationId { get; set; }
        public string? Province { get; set; }

        public string? District { get; set; }

        public string? ZoneDeSante { get; set; }

        public string? TypeFosa { get; set; }

        public int FosaId { get; set; }

        public string? Fosa { get; set; }

        public string? Prestataire { get; set; }

        public string? PrestationCategorie { get; set; }

        public int? EffectifDeclare { get; set; }

        public decimal? CoutUnitaireDeclare { get; set; }

        public decimal? CoutTotalDeclare { get; set; }

        public int? EffectifVerifie { get; set; }

        public decimal? CoutUnitaireVerifie { get; set; }

        public decimal? CoutTotalVerifie { get; set; }

        public string? Monnaie { get; set; }

        public string? Mois { get; set; }

        public string? Annee { get; set; }

        public DateOnly? DatePrestation { get; set; }
    }
}
