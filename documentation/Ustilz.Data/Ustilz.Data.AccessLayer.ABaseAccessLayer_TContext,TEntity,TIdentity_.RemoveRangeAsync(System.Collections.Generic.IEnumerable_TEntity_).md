#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer](Ustilz.Data.AccessLayer.md 'Ustilz.Data.AccessLayer').[ABaseAccessLayer&lt;TContext,TEntity,TIdentity&gt;](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>')

## ABaseAccessLayer<TContext,TEntity,TIdentity>.RemoveRangeAsync(IEnumerable<TEntity>) Method

Async method using bulk deletion method to remove data object from db context.

```csharp
public System.Threading.Tasks.Task<int> RemoveRangeAsync(System.Collections.Generic.IEnumerable<TEntity> models);
```
#### Parameters

<a name='Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.RemoveRangeAsync(System.Collections.Generic.IEnumerable_TEntity_).models'></a>

`models` [System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TEntity](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md#Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')

Implements [RemoveRangeAsync(IEnumerable&lt;TIdentity&gt;)](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.RemoveRangeAsync(System.Collections.Generic.IEnumerable_TIdentity_).md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>.RemoveRangeAsync(System.Collections.Generic.IEnumerable<TIdentity>)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns number of state entries written to the database.