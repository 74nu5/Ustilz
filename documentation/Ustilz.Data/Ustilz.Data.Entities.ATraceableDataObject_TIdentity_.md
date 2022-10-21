#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.Entities](Ustilz.Data.Entities.md 'Ustilz.Data.Entities')

## ATraceableDataObject<TIdentity> Class

Base abstract definition of an object model.  
Every objects must have a creation date and a modification date.

```csharp
public abstract class ATraceableDataObject<TIdentity> : Ustilz.Data.Entities.ADataObject<TIdentity>,
Ustilz.Data.Abstractions.ITraceableDataObject
    where TIdentity : System.IComparable<TIdentity>
```
#### Type parameters

<a name='Ustilz.Data.Entities.ATraceableDataObject_TIdentity_.TIdentity'></a>

`TIdentity`

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Ustilz.Data.Entities.ADataObject&lt;](Ustilz.Data.Entities.ADataObject_TIdentity_.md 'Ustilz.Data.Entities.ADataObject<TIdentity>')[TIdentity](Ustilz.Data.Entities.ATraceableDataObject_TIdentity_.md#Ustilz.Data.Entities.ATraceableDataObject_TIdentity_.TIdentity 'Ustilz.Data.Entities.ATraceableDataObject<TIdentity>.TIdentity')[&gt;](Ustilz.Data.Entities.ADataObject_TIdentity_.md 'Ustilz.Data.Entities.ADataObject<TIdentity>') &#129106; ATraceableDataObject<TIdentity>

Implements [ITraceableDataObject](Ustilz.Data.Abstractions.ITraceableDataObject.md 'Ustilz.Data.Abstractions.ITraceableDataObject')

| Properties | |
| :--- | :--- |
| [CreationDate](Ustilz.Data.Entities.ATraceableDataObject_TIdentity_.CreationDate.md 'Ustilz.Data.Entities.ATraceableDataObject<TIdentity>.CreationDate') | Gets or sets the date and time creation of the object. |
| [LastModifiedDate](Ustilz.Data.Entities.ATraceableDataObject_TIdentity_.LastModifiedDate.md 'Ustilz.Data.Entities.ATraceableDataObject<TIdentity>.LastModifiedDate') | Gets or sets the date and time of the last modification of the object. |
