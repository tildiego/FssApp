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
    /// <typeparam name="Annee"></typeparam>
    public class AnneeValidator : AbstractValidator<Annee>
    {
        public AnneeValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("L'identifiant de l'année est obligatoire.");
            RuleFor(x => x.Nom)
                .NotEmpty().WithMessage("Le nom de l'année est obligatoire.")
                .MaximumLength(100).WithMessage("Le nom de l'année ne peut pas dépasser 4 caractères.");
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<Annee>.CreateWithOptions((Annee)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
