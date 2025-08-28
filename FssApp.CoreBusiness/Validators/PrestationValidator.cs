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
                .GreaterThan(0).WithMessage("Le nom de la formation sanitaire est obligatoire.");
            RuleFor(x => x.PrestataireId)
                .GreaterThan(0).WithMessage("Le type de prestataire est obligatoire.");
            RuleFor(x => x.PrestationCategorieId)
                .GreaterThan(0).WithMessage("Le type de prestation est obligatoire.");
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
