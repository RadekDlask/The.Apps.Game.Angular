using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace The.Apps.Game.Web.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class InvalidCharacterAttribute : ValidationAttribute
    {
        private readonly string _chars;
        private string _invalidCharacter;
        public InvalidCharacterAttribute(string chars) : base("{0} contains invalid character {1}.")
        {
            _chars = chars;
        }
        public override string FormatErrorMessage(string name)
        {
            return string.Format(ErrorMessageString, name, _invalidCharacter);
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                for (int i = 0; i < _chars.Length; i++)
                {
                    var valueAsString = value.ToString();
                    if (valueAsString.Contains(_chars[i]))
                    {
                        _invalidCharacter = _chars[i].ToString();
                        return new ValidationResult(FormatErrorMessage(validationContext.DisplayName));
                    }
                }
            }
            return ValidationResult.Success;
        }
    }
}