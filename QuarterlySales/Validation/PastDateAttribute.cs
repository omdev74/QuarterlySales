// Validation/PastDateAttribute.cs
using System;
using System.ComponentModel.DataAnnotations;

public class PastDateAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        if (value is null)
        {
            return true; // or provide an appropriate validation result for null values
        }

        DateTime date = (DateTime)value;
        return date < DateTime.Now;
    }
}
