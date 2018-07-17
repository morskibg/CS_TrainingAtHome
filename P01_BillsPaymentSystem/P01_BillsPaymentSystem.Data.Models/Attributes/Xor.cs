

using System;
using System.ComponentModel.DataAnnotations;

namespace P01_BillsPaymentSystem.Data.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class Xor : ValidationAttribute
    {
        private string _targetPropertyName;

        public Xor(string targetPropertyName)
        {
            this._targetPropertyName = targetPropertyName;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var targetPropertyValue = validationContext
                .ObjectType
                .GetProperty(_targetPropertyName)
                .GetValue(validationContext.ObjectInstance);
            if (targetPropertyValue == null ^ value == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("One and only Id should be null");
        }
    }
}
