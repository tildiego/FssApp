using FluentValidation;
using FssApp.CoreBusiness.Helpers;
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
    /// <typeparam name="PrestationsHelper"></typeparam>
    public class PrestationsHelperValidator : AbstractValidator<PrestationsHelper>
    {
        public PrestationsHelperValidator()
        {
            RuleFor(x => x.FormationSanitaireDto).NotNull();
            RuleFor(x => x.Prestataire).SetValidator(new PrestataireValidator());
            RuleFor(x => x.PrestationCategorie).NotEmpty();
            RuleFor(x => x.Annee).NotNull();
            RuleFor(x => x.Mois).NotNull();
            RuleFor(x => x.Monnaie).NotNull();
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PrestationsHelper>.CreateWithOptions((PrestationsHelper)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
