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
    /// <typeparam name="PrestationCategorie"></typeparam>
    public class PrestationCategorieValidator : AbstractValidator<PrestationCategorie>
    {
        public PrestationCategorieValidator()
        {
            RuleFor(x => x.Id)
                .GreaterThan(0).WithMessage("L'identifiant de la prestation categorie est obligatoire.");
            RuleFor(x => x.Nom)
                .NotEmpty().WithMessage("Le nom de la prestation categorie est obligatoire.")
                .MaximumLength(100).WithMessage("Le nom de la prestation categorie ne peut pas dépasser 50 caractères.");
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<PrestationCategorie>.CreateWithOptions((PrestationCategorie)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
