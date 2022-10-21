### [Ustilz.Attributes](Ustilz.Attributes.md 'Ustilz.Attributes')

## RequiredIfAttribute Class

Validation attribute that flag a target property as required if another property constraint is true.

```csharp
public class RequiredIfAttribute : System.ComponentModel.DataAnnotations.RequiredAttribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; [System.ComponentModel.DataAnnotations.ValidationAttribute](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.ValidationAttribute 'System.ComponentModel.DataAnnotations.ValidationAttribute') &#129106; [System.ComponentModel.DataAnnotations.RequiredAttribute](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.DataAnnotations.RequiredAttribute 'System.ComponentModel.DataAnnotations.RequiredAttribute') &#129106; RequiredIfAttribute

| Properties | |
| :--- | :--- |
| [PropertyName](Ustilz.Attributes.RequiredIfAttribute.PropertyName.md 'Ustilz.Attributes.RequiredIfAttribute.PropertyName') | Gets or sets the property name used in constraint. |
| [Value](Ustilz.Attributes.RequiredIfAttribute.Value.md 'Ustilz.Attributes.RequiredIfAttribute.Value') | Gets or sets the property value that make the target property required. |

| Methods | |
| :--- | :--- |
| [IsValid(object, ValidationContext)](Ustilz.Attributes.RequiredIfAttribute.IsValid(object,System.ComponentModel.DataAnnotations.ValidationContext).md 'Ustilz.Attributes.RequiredIfAttribute.IsValid(object, System.ComponentModel.DataAnnotations.ValidationContext)') | Checks the validation state of the target property. |
