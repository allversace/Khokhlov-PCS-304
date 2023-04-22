﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace LabTwo
{
    public static class ValidationExtensions
    {
        public static void Validate(this IValidatable obj)
        { 
            var validationContext = new ValidationContext(obj);//Описывает контекст, в котором проводится проверка.
            var validationResults = new List<ValidationResult>(); 
            if (!Validator.TryValidateObject(obj, validationContext, validationResults, true))
            {
                throw new ValidationException(string.Join(Environment.NewLine,
                    validationResults.Select(r => r.ErrorMessage)));
            }
            var customValidationResults = obj.Validate(validationContext);
            if (customValidationResults != null && customValidationResults.Any())
            {
                throw new ValidationException(string.Join(Environment.NewLine,
                    customValidationResults.Select(r => r.ErrorMessage)));
            }
        }
    }
}