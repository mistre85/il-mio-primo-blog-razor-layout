﻿using System.ComponentModel.DataAnnotations;

namespace il_mio_primo_blog.Validator
{
    public class AlmenoDueParoleAttribute : ValidationAttribute
    {
        //public override bool IsValid(object? value)
        //{
        //    return base.IsValid(value);
        //}

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string fieldValue = (string)value;

            if (fieldValue == null || !fieldValue.Trim().Contains(' '))
            {
                return new ValidationResult("Il campo deve contenere almeno due parole");
            }

            return ValidationResult.Success;
        }
    }
}
