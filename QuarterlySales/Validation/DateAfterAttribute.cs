// Validation/DateAfterAttribute.cs
using System;
using System.ComponentModel.DataAnnotations;

[AttributeUsage(AttributeTargets.Property)]
public class DateAfterAttribute : ValidationAttribute
{
    private readonly string _startDate;

    public DateAfterAttribute(string startDate)
    {
        _startDate = startDate ?? throw new ArgumentNullException(nameof(startDate));
    }

    protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
    {
        if (value is null)
        {
            return ValidationResult.Success;
        }

        if (value is not DateTime date)
        {
            throw new ArgumentException("The value must be of type DateTime.", nameof(value));
        }

        DateTime startDate = DateTime.Parse(_startDate);

        if (date > startDate)
        {
            return ValidationResult.Success;
        }
        else
        {
            return new ValidationResult(ErrorMessage);
        }
    }
}
