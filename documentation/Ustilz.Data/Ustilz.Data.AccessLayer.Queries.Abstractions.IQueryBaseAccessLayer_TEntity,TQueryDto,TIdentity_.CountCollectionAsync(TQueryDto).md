#### [Ustilz.Data](index.md 'index')
### [Ustilz.Data.AccessLayer.Queries.Abstractions](Ustilz.Data.AccessLayer.Queries.Abstractions.md 'Ustilz.Data.AccessLayer.Queries.Abstractions').[IQueryBaseAccessLayer&lt;TEntity,TQueryDto,TIdentity&gt;](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>')

## IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>.CountCollectionAsync(TQueryDto) Method

Method that retrieve the count of collection of data according to the query.

```csharp
System.Threading.Tasks.Task<int> CountCollectionAsync(TQueryDto query);
```
#### Parameters

<a name='Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.CountCollectionAsync(TQueryDto).query'></a>

`query` [TQueryDto](Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.md#Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer_TEntity,TQueryDto,TIdentity_.TQueryDto 'Ustilz.Data.AccessLayer.Queries.Abstractions.IQueryBaseAccessLayer<TEntity,TQueryDto,TIdentity>.TQueryDto')

Query object to filter data.

#### Returns
[System.Threading.Tasks.Task&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task-1 'System.Threading.Tasks.Task`1')  
Returns the result count item according the query.