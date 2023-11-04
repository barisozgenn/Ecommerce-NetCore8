using System;
using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation
{
    public class ValidationTool
    {
      public static void Validatie(IValidator validator, object entity)
        {
            var context = new ValidationContext<object>(entity);
            var resulValidation = validator.Validate(context: context);

            if (!resulValidation.IsValid)
            {
                throw new ValidationException(resulValidation.Errors);
            }
        }
    }
}

