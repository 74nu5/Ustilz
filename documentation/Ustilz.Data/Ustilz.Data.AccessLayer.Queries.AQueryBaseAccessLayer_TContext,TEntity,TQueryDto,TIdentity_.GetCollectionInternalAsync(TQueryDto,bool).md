#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer.Queries](Ustilz.Data.AccessLayer.Queries.md 'Ustilz.Data.AccessLayer.Queries').[AQueryBaseAccessLayer&lt;TContext,TEntity,TQueryDto,TIdentity&gt;](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>')

## AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.GetCollectionInternalAsync(TQueryDto, bool) Method

Internal method that retrieve a queryable collection of data according to the query.

```csharp
protected abstract System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TEntity>> GetCollectionInternalAsync(TQueryDto query, bool isPageable=true);
```
#### Parameters

<a name='Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.GetCollectionInternalAsync(TQueryDto,bool).query'></a>

`query` [TQueryDto](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TQueryDto 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.TQueryDto')

Query object to filter data.

<a name='Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.GetCollectionInternalAsync(TQueryDto,bool).isPageable'></a>

`isPageable` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Boolean that determines if the result is paged.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TEntity](Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer_TContext,TEntity,TQueryDto,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.Queries.AQueryBaseAccessLayer<TContext,TEntity,TQueryDto,TIdentity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns the queryable list of entity.