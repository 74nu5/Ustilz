#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer.Abstractions](Ustilz.Data.AccessLayer.Abstractions.md 'Ustilz.Data.AccessLayer.Abstractions').[IBaseAccessLayer&lt;TEntity,TIdentity&gt;](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>')

## IBaseAccessLayer<TEntity,TIdentity>.RemoveRangeAsync(IEnumerable<TIdentity>) Method

Async method using bulk deletion method to remove data object from db context.

```csharp
System.Threading.Tasks.Task<int> RemoveRangeAsync(System.Collections.Generic.IEnumerable<TIdentity> ids);
```
#### Parameters

<a name='Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.RemoveRangeAsync(System.Collections.Generic.IEnumerable_TIdentity_).ids'></a>

`ids` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TIdentity](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.md#Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.TIdentity 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>.TIdentity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Enumerable of ids of Data object to remove.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns number of state entries written to the database.