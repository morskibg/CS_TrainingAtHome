

using System;
using System.ComponentModel.DataAnnotations;

namespace P01_BillsPaymentSystem.Data.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NonUnicode : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string textToValidate = (string) value;
            string errorMsg = "The input text can't contain unicode character";
            for (int i = 0; i < textToValidate.Length; i++)
            {
                if(textToValidate[i] > 255)
                {
                    return new ValidationResult(errorMsg);
                }
            }
            return ValidationResult.Success;
        }
    }
}
