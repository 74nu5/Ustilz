#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer](Ustilz.Data.AccessLayer.md 'Ustilz.Data.AccessLayer').[ABaseAccessLayer&lt;TContext,TEntity,TIdentity&gt;](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>')

## ABaseAccessLayer<TContext,TEntity,TIdentity>.RemoveAsync(TEntity) Method

Async Method that remove a specific object in Db.

```csharp
public System.Threading.Tasks.Task<int> RemoveAsync(TEntity model);
```
#### Parameters

<a name='Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.RemoveAsync(TEntity).model'></a>

`model` [TEntity](Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.md#Ustilz.Data.AccessLayer.ABaseAccessLayer_TContext,TEntity,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.ABaseAccessLayer<TContext,TEntity,TIdentity>.TEntity')

Implements [RemoveAsync(TIdentity)](Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer_TEntity,TIdentity_.RemoveAsync(TIdentity).md 'Ustilz.Data.AccessLayer.Abstractions.IBaseAccessLayer<TEntity,TIdentity>.RemoveAsync(TIdentity)')

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns number of state entries written to the database.