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
    /// <typeparam name="FormationSanitaire"></typeparam>
    public class FormationSanitaireValidator : AbstractValidator<FormationSanitaire>
    {
        public FormationSanitaireValidator()
        {
            RuleFor(x => x.Nom)
                .NotEmpty().WithMessage("Le nom de la formation sanitaire est obligatoire.")
                .MaximumLength(100).WithMessage("Le nom de la formation sanitaire ne peut pas dépasser 100 caractères.");

            RuleFor(x => x.TypeFormationSanitaireId)
                .GreaterThan(0).WithMessage("Le type de formation sanitaire est obligatoire.");
            RuleFor(x => x.ZoneDeSanteId)
                .GreaterThan(0).WithMessage("La zone de santé est obligatoire.");
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<FormationSanitaire>.CreateWithOptions((FormationSanitaire)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
