#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer.Queries.Abstractions](Ustilz.Data.AccessLayer.Queries.Abstractions.md 'Ustilz.Data.AccessLayer.Queries.Abstractions').[IQueryBaseAccessLayer&lt;TEntity,TQueryDto,TIdentity&gt;](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>')

## IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>.GetCollectionAsync(TQueryDto, bool) Method

Method that retrieve a collection of data according to the query.

```csharp
System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TEntity>> GetCollectionAsync(TQueryDto query, bool isPageable=true);
```
#### Parameters

<a name='Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.GetCollectionAsync(TQueryDto,bool).query'></a>

`query` [TQueryDto](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.TQueryDto 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>.TQueryDto')

Query object to filter data.

<a name='Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.GetCollectionAsync(TQueryDto,bool).isPageable'></a>

`isPageable` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

Boolean that determines if the result is paged.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Collections.Generic.IEnumerable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[TEntity](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.TEntity 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>.TEntity')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1 'System.Collections.Generic.IEnumerable`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns the collection result of query.