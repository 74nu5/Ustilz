#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.Entities](Ustilz.Data.Entities.md 'Ustilz.Data.Entities')

## ADataObject<TIdentity> Class

Base abstract definition of an object model.  
Every objects must have a technical id, a creation date and a modification date.

```csharp
public abstract class ADataObject<TIdentity> :
Ustilz.Data.Abstractions.IDto<TIdentity>
    where TIdentity : System.IComparable<TIdentity>
```
#### Type parameters

<a name='Ustilz.Data.Entities.ADataObject_TIdentity_.TIdentity'></a>

`TIdentity`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ADataObject<TIdentity>

Derived  
&#8627; [AStateDataObject&lt;TIdentity&gt;](Ustilz.Data.Entities.AStateDataObject_TIdentity_.md 'Ustilz.Data.Entities.AStateDataObject<TIdentity>')  
&#8627; [ATraceableDataObject&lt;TIdentity&gt;](Ustilz.Data.Entities.ATraceableDataObject_TIdentity_.md 'Ustilz.Data.Entities.ATraceableDataObject<TIdentity>')

Implements [Ustilz.Data.Abstractions.IDto&lt;](Ustilz.Data.Abstractions.IDto_TIdentity_.md 'Ustilz.Data.Abstractions.IDto<TIdentity>')[TIdentity](Ustilz.Data.Entities.ADataObject_TIdentity_.md#Ustilz.Data.Entities.ADataObject_TIdentity_.TIdentity 'Ustilz.Data.Entities.ADataObject<TIdentity>.TIdentity')[&gt;](Ustilz.Data.Abstractions.IDto_TIdentity_.md 'Ustilz.Data.Abstractions.IDto<TIdentity>')

| Properties | |
| :--- | :--- |
| [Id](Ustilz.Data.Entities.ADataObject_TIdentity_.Id.md 'Ustilz.Data.Entities.ADataObject<TIdentity>.Id') | Gets or sets the primary key. |
