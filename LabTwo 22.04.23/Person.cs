using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LabTwo
{
    public class Person : IValidatable
    {
        [Required]
        public string Name { get; set; }
        [Range(0,99)]
        public int Age { get; set; }
        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Name == "Arthur" && Age < 18)
            {
                yield return new ValidationResult("Исключение данных");//для предоставления следующего значения в итерации
            }
        }
    }
}