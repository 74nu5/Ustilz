namespace Ustilz.Attributes;

using System.ComponentModel.DataAnnotations;

/// <summary>
///     Validation attribute that flag a target property as required if another property constraint is true.
/// </summary>
public class RequiredIfAttribute : RequiredAttribute
{
    /// <summary>
    ///     Gets or sets the property name used in constraint.
    /// </summary>
    public string PropertyName { get; set; } = null!;

    /// <summary>
    ///     Gets or sets the property value that make the target property required.
    /// </summary>
    public object Value { get; set; } = null!;

    /// <summary>
    ///     Checks the validation state of the target property.
    /// </summary>
    /// <param name="value">Current value of the property.</param>
    /// <param name="validationContext">The validation context.</param>
    /// <returns>
    ///     Returns a <seealso cref="ValidationResult" />.
    /// </returns>
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        _ = this.PropertyName ?? throw new ArgumentNullException(nameof(this.PropertyName));

        var instance = validationContext.ObjectInstance;
        var type = instance.GetType();
        var propertyValue = type.GetProperty(this.PropertyName)?.GetValue(instance, null);

        return propertyValue?.ToString() == this.Value.ToString()
                   ? base.IsValid(value, validationContext)
                   : ValidationResult.Success;
    }
}
