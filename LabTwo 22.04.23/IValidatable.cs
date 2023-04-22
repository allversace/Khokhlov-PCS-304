using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LabTwo
{
    public interface IValidatable
    {
        IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
    }
}