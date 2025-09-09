using FluentValidation;
using FssApp.CoreBusiness.ExtensionMethods;
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
    /// <typeparam name="Prestataire"></typeparam>
    public class PrestataireValidator : AbstractValidator<Prestataire>
    {
        public PrestataireValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("L'identifiant du prestataire est obligatoire.");
            RuleFor(x => x.Type)
                .NotEmpty().WithMessage("Le type de prestataire est obligatoire.")
                .MaximumLength(100).WithMessage("Le type de prestataire ne peut pas dépasser 20 caractères.");
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<Prestataire>.CreateWithOptions((Prestataire)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
