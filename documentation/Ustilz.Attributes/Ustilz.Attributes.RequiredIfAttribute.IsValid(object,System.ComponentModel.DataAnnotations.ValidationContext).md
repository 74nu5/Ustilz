### [Ustilz.Attributes](Ustilz.Attributes.md 'Ustilz.Attributes').[RequiredIfAttribute](Ustilz.Attributes.RequiredIfAttribute.md 'Ustilz.Attributes.RequiredIfAttribute')

## RequiredIfAttribute.IsValid(object, ValidationContext) Method

Checks the validation state of the target property.

```csharp
protected override System.ComponentModel.DataAnnotations.ValidationResult? IsValid(object? value, System.ComponentModel.DataAnnotations.ValidationContext validationContext);
```
#### Parameters

<a name='Ustilz.Attributes.RequiredIfAttribute.IsValid(object,System.ComponentModel.DataAnnotations.ValidationContext).value'></a>

`value` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

Current value of the property.

<a name='Ustilz.Attributes.RequiredIfAttribute.IsValid(object,System.ComponentModel.DataAnnotations.ValidationContext).validationContext'></a>

`validationContext` [System.ComponentModel.DataAnnotations.ValidationContext](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationContext 'System.ComponentModel.DataAnnotations.ValidationContext')

The validation context.

#### Returns
[System.ComponentModel.DataAnnotations.ValidationResult](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationResult 'System.ComponentModel.DataAnnotations.ValidationResult')  
Returns a <seealso cref="T:System.ComponentModel.DataAnnotations.ValidationResult"/>.