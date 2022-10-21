#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer.Abstractions](Ustilz.Data.AccessLayer.Abstractions.md 'Ustilz.Data.AccessLayer.Abstractions').[IBaseAccessLayer&lt;TEntity,TIdentity&gt;](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')

## IBaseAccessLayer<TEntity,TIdentity>.Exists(TIdentity) Method

Check the existence of an object in a collection from based on its id.

```csharp
bool Exists(TIdentity id);
```
#### Parameters

<a name='Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.Exists(TIdentity).id'></a>

`id` [TIdentity](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md#Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.TIdentity 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>.TIdentity')

Id of object to check.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Returns true if object exists, false otherwise.