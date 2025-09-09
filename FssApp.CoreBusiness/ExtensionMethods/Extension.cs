using FluentValidation;
using FssApp.CoreBusiness.DTOs;
using FssApp.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.CoreBusiness.ExtensionMethods
{
    public static class Extension
    {
        public static string To_String(this FormationSanitaire fosa)  =>
            $"{fosa.Id} | {fosa.Nom}";

        public static string To_String(this FormationSanitaireDto fosa) =>
           $"{fosa.FosaId} | {fosa.Fosa} ({fosa.TypeFosa}) ({fosa.Province}, {fosa.District}, {fosa.ZoneDeSante})";

        public static string To_String(this Prestataire prestataire) =>
           $"{prestataire.Id} | {prestataire.Type}";

        public static string To_String(this PrestationCategorie prestationCategorie) =>
           $"{prestationCategorie.Id} | {prestationCategorie.Nom}";
    }
}
