using Microsoft.Data.Edm.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using ValidationContext = System.ComponentModel.DataAnnotations.ValidationContext;
using ValidationResult = System.ComponentModel.DataAnnotations.ValidationResult;

namespace Core
{
    public class UserValidation: NameValidation
    {
        protected const string requiredLegth = "UserName length should be between 2 and 7";
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return error(requiredField);
            var s = value.ToString();
            if (s.Length < 2) return error(requiredLegth);
            if (s.Length > 7) return error(requiredLegth);
            if (!onlyLetters(s)) return error(useOnlyLetters);
            return ValidationResult.Success;
        }
    }
}
