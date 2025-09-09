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
    /// <typeparam name="Moi"></typeparam>
    public class MoisValidator : AbstractValidator<Moi>
    {
        public MoisValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("L'identifiant du mois est obligatoire.");
            RuleFor(x => x.Nom)
                .NotEmpty().WithMessage("Le nom du mois est obligatoire.")
                .MaximumLength(100).WithMessage("Le nom du mois ne peut pas dépasser 10 caractères.");
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<Moi>.CreateWithOptions((Moi)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
