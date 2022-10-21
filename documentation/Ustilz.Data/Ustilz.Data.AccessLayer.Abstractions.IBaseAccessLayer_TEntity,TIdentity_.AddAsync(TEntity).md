#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer.Abstractions](Ustilz.Data.AccessLayer.Abstractions.md 'Ustilz.Data.AccessLayer.Abstractions').[IBaseAccessLayer&lt;TEntity,TIdentity&gt;](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')

## IBaseAccessLayer<TEntity,TIdentity>.AddAsync(TEntity) Method

Async Method that add new object in Db.

```csharp
System.Threading.Tasks.Task<TIdentity> AddAsync(TEntity model);
```
#### Parameters

<a name='Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.AddAsync(TEntity).model'></a>

`model` [TEntity](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md#Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>.TEntity')

Object model to add.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[TIdentity](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md#Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.TIdentity 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>.TIdentity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns the Id of newly created object.