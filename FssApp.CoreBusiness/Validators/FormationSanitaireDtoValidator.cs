using FluentValidation;
using FssApp.CoreBusiness.DTOs;
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
    /// <typeparam name="FormationSanitaireDto"></typeparam>
    public class FormationSanitaireDtoValidator : AbstractValidator<FormationSanitaireDto>
    {
        public FormationSanitaireDtoValidator()
        {
            RuleFor(x => x.FosaId)
                .GreaterThan(0).WithMessage("L'identifiant de la formation sanitaire est obligatoire.");
            RuleFor(x => x.Fosa)
                .NotEmpty().WithMessage("La formation sanitaire est obligatoire.")
                .MaximumLength(100).WithMessage("La formation sanitaire ne peut pas dépasser 100 caractères.");
            RuleFor(x => x.TypeFosa)
                .NotEmpty().WithMessage("La formation sanitaire est obligatoire.")
                .MaximumLength(100).WithMessage("La formation sanitaire ne peut pas dépasser 100 caractères.");
            RuleFor(x => x.ZoneDeSante)
                .NotEmpty().WithMessage("La zone de santé est obligatoire.")
                .MaximumLength(100).WithMessage("La Zone de Sante ne peut pas dépasser 100 caractères.");
        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<FormationSanitaireDto>.CreateWithOptions((FormationSanitaireDto)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}
