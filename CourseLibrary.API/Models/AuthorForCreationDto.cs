using CourseLibrary.API.ValidationAttributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CourseLibrary.API.Models
{
    [FirstNameMustBeDifferentFromLastName(ErrorMessage = "The Provided Firstname Should be different from the LastName")]
    public class AuthorForCreationDto : IValidatableObject
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string MainCategory { get; set; }
        public ICollection<CourseForCreationDto> Courses { get; set; } 
            = new List<CourseForCreationDto>();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(FirstName == MainCategory)
            {
                yield return new ValidationResult("The Provided Firstname Should be different from the MainCategory",
                    new[] {"AuthorForCreationDto"});// we can give any name. no need to put class name
            }
        }
    }
}
