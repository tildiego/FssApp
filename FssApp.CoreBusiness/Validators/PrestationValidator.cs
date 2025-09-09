using FluentValidation;
using FssApp.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FssApp.CoreBusiness.Validators
{
    /// <summary>
    /// A standard validator for the collection object
    /// </summary>
    /// <typeparam name="PrestationsSynthese"></typeparam>
    public class PrestationValidator : AbstractValidator<PrestationsSynthese>
    {
        public PrestationValidator()
        {
            RuleFor(x => x.FormationSanitaireId)
                .GreaterThan(0).WithMessage("La formation sanitaire est obligatoire.");
            RuleFor(x => x.PrestataireId)
                .GreaterThan(0).WithMessage("Le prestataire est obligatoire.");
            RuleFor(x => x.PrestationCategorieId)
                .GreaterThan(0).WithMessage("La catégorie de la prestation est obligatoire.");
            RuleFor(x => x.MoisId)
                .GreaterThan(0).WithMessage("Le mois est obligatoire.");
            RuleFor(x => x.AnneeId)
                .GreaterThan(0).WithMessage("L'année est obligatoire.");


            //RuleFor(x => x.Prestataire)
            //    .NotNull().WithMessage("Le type de prestataire est obligatoire.")
            //    .NotEmpty().WithMessage("Le type de prestataire est obligatoire.");
            //RuleFor(x => x.PrestationCategorie)
            //    .NotNull().WithMessage("Le type de prestation est obligatoire.")
            //    .NotEmpty().WithMessage("Le type de prestation est obligatoire.");
            //RuleFor(x => x.Annee)
            //    .NotNull().WithMessage("L'année est obligatoire.")
            //    .NotEmpty().WithMessage("L'année est obligatoire.");
            //RuleFor(x => x.Mois)
            //    .NotNull().WithMessage("Le mois est obligatoire.")
            //    .NotEmpty().WithMessage("Le mois est obligatoire.");

            //RuleFor(x => x.Prestataire)
            //    .Must(BeAValidPrestataire).WithMessage("Le type de prestataire est obligatoire.");
        }

        private bool BeAValidPrestataire(Prestataire prestataire)
        {
            return prestataire is not null;
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PrestationsSynthese>.CreateWithOptions((PrestationsSynthese)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
