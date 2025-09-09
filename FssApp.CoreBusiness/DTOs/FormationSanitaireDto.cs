using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FssApp.CoreBusiness.DTOs;

public class FormationSanitaireDto
{
    [Key]
    public int FosaId { get; set; }
    public string? Province { get; set; }

    public string? District { get; set; }

    public string? ZoneDeSante { get; set; }

    public string? TypeFosa { get; set; }


    public string Fosa { get; set; } = null!;

    public string? Statut { get; set; }

    public string? Description { get; set; }

    public string? IntituleCompteBanquaire { get; set; }

    public bool? ToBeDeleted { get; set; }

    public string? Adresse { get; set; }

    public string? Telephone { get; set; }

    public string? ResponsableNom { get; set; }

    public string? ResponsablePostNom { get; set; }

    public string? ResponsablePrenom { get; set; }

    public string? ResponsableEmail { get; set; }

    public string? ResponsableTelephone { get; set; }

    public bool FosaConventionnee { get; set; }
}
