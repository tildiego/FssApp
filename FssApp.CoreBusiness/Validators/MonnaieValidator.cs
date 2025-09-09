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
    /// <typeparam name="Monnaie"></typeparam>
    public class MonnaieValidator : AbstractValidator<Monnaie>
    {
        public MonnaieValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("L'identifiant de la monnaie est obligatoire.");
            RuleFor(x => x.Code)
                .NotEmpty().WithMessage("Le code de la monnaie est obligatoire.")
                .MaximumLength(100).WithMessage("Le code de la monnaie ne peut pas dépasser 3 caractères.");
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<Monnaie>.CreateWithOptions((Monnaie)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
