
using CourseLibrary.API.Models;
using System.ComponentModel.DataAnnotations;


namespace CourseLibrary.API.ValidationAttributes
{
    public class FirstNameMustBeDifferentFromLastNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            var author = (AuthorForCreationDto)validationContext.ObjectInstance;

            if (author.FirstName == author.LastName)
            {
                return new ValidationResult(ErrorMessage,
                    new[] { nameof(AuthorForCreationDto) });
            }

            return ValidationResult.Success;
        }
    }
}
