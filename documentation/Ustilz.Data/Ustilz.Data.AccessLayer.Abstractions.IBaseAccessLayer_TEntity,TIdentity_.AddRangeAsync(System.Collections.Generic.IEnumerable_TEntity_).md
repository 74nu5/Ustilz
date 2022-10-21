#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer.Abstractions](Ustilz.Data.AccessLayer.Abstractions.md 'Ustilz.Data.AccessLayer.Abstractions').[IBaseAccessLayer&lt;TEntity,TIdentity&gt;](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')

## IBaseAccessLayer<TEntity,TIdentity>.AddRangeAsync(IEnumerable<TEntity>) Method

Async Method that add a range of new object in Db.

```csharp
System.Threading.Tasks.Task<int> AddRangeAsync(System.Collections.Generic.IEnumerable<TEntity> models);
```
#### Parameters

<a name='Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.AddRangeAsync(System.Collections.Generic.IEnumerable_TEntity_).models'></a>

`models` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TEntity](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md#Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Enumerable of objects model to add.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns number of state entries written to the database.